using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Memory;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.Javascript.Strings;

namespace Root.Coding.Code.Api.E01D.Javascript
{
    public class JavascriptStringsApi
    {
        internal readonly bool[] SingleQuoteCharEscapeFlags = new bool[128];
        internal readonly bool[] DoubleQuoteCharEscapeFlags = new bool[128];
        internal readonly bool[] HtmlCharEscapeFlags = new bool[128];

        private const int UnicodeTextLength = 6;

        public JavascriptStringsApi()
        {
            IList<char> escapeChars = new List<char>
            {
                '\n', '\r', '\t', '\\', '\f', '\b',
            };
            for (int i = 0; i < ' '; i++)
            {
                escapeChars.Add((char)i);
            }

            foreach (char escapeChar in escapeChars.Union(new[] { '\'' }))
            {
                SingleQuoteCharEscapeFlags[escapeChar] = true;
            }
            foreach (char escapeChar in escapeChars.Union(new[] { '"' }))
            {
                DoubleQuoteCharEscapeFlags[escapeChar] = true;
            }
            foreach (char escapeChar in escapeChars.Union(new[] { '"', '\'', '<', '>', '&' }))
            {
                HtmlCharEscapeFlags[escapeChar] = true;
            }
        }

        private const string EscapedUnicodeText = "!";

        public bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
        {
            if (stringEscapeHandling == StringEscapeHandling.EscapeHtml)
            {
                return HtmlCharEscapeFlags;
            }

            if (quoteChar == '"')
            {
                return DoubleQuoteCharEscapeFlags;
            }

            return SingleQuoteCharEscapeFlags;
        }

        public bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
        {
            if (s == null)
            {
                return false;
            }

            foreach (char c in s)
            {
                if (c >= charEscapeFlags.Length || charEscapeFlags[c])
                {
                    return true;
                }
            }

            return false;
        }

        public void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters,
            bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, ArrayPoolApi_I<char> bufferPool, ref char[] writeBuffer)
        {
            // leading delimiter
            if (appendDelimiters)
            {
                writer.Write(delimiter);
            }

            if (!string.IsNullOrEmpty(s))
            {
                int lastWritePosition = FirstCharToEscape(s, charEscapeFlags, stringEscapeHandling);
                if (lastWritePosition == -1)
                {
                    writer.Write(s);
                }
                else
                {
                    if (lastWritePosition != 0)
                    {
                        if (writeBuffer == null || writeBuffer.Length < lastWritePosition)
                        {
                            writeBuffer = XMemory.EnsureBufferSize(bufferPool, lastWritePosition, writeBuffer);
                        }

                        // write unchanged chars at start of text.
                        s.CopyTo(0, writeBuffer, 0, lastWritePosition);
                        writer.Write(writeBuffer, 0, lastWritePosition);
                    }

                    int length;
                    for (int i = lastWritePosition; i < s.Length; i++)
                    {
                        char c = s[i];

                        if (c < charEscapeFlags.Length && !charEscapeFlags[c])
                        {
                            continue;
                        }

                        string escapedValue;

                        switch (c)
                        {
                            case '\t':
                                escapedValue = @"\t";
                                break;
                            case '\n':
                                escapedValue = @"\n";
                                break;
                            case '\r':
                                escapedValue = @"\r";
                                break;
                            case '\f':
                                escapedValue = @"\f";
                                break;
                            case '\b':
                                escapedValue = @"\b";
                                break;
                            case '\\':
                                escapedValue = @"\\";
                                break;
                            case '\u0085': // Next Line
                                escapedValue = @"\u0085";
                                break;
                            case '\u2028': // Line Separator
                                escapedValue = @"\u2028";
                                break;
                            case '\u2029': // Paragraph Separator
                                escapedValue = @"\u2029";
                                break;
                            default:
                                if (c < charEscapeFlags.Length || stringEscapeHandling == StringEscapeHandling.EscapeNonAscii)
                                {
                                    if (c == '\'' && stringEscapeHandling != StringEscapeHandling.EscapeHtml)
                                    {
                                        escapedValue = @"\'";
                                    }
                                    else if (c == '"' && stringEscapeHandling != StringEscapeHandling.EscapeHtml)
                                    {
                                        escapedValue = @"\""";
                                    }
                                    else
                                    {
                                        if (writeBuffer == null || writeBuffer.Length < UnicodeTextLength)
                                        {
                                            writeBuffer = XMemory.EnsureBufferSize(bufferPool, UnicodeTextLength, writeBuffer);
                                        }

                                        XStrings.ToCharAsUnicode(c, writeBuffer);

                                        // slightly hacky but it saves multiple conditions in if test
                                        escapedValue = EscapedUnicodeText;
                                    }
                                }
                                else
                                {
                                    escapedValue = null;
                                }
                                break;
                        }

                        if (escapedValue == null)
                        {
                            continue;
                        }

                        bool isEscapedUnicodeText = string.Equals(escapedValue, EscapedUnicodeText);

                        if (i > lastWritePosition)
                        {
                            length = i - lastWritePosition + ((isEscapedUnicodeText) ? UnicodeTextLength : 0);
                            int start = (isEscapedUnicodeText) ? UnicodeTextLength : 0;

                            if (writeBuffer == null || writeBuffer.Length < length)
                            {
                                char[] newBuffer = XMemory.RentBuffer(bufferPool, length);

                                // the unicode text is already in the buffer
                                // copy it over when creating new buffer
                                if (isEscapedUnicodeText)
                                {
                                    XDebug.Assert(writeBuffer != null, "Write buffer should never be null because it is set when the escaped unicode text is encountered.");

                                    Array.Copy(writeBuffer, newBuffer, UnicodeTextLength);
                                }

                                XMemory.ReturnBuffer(bufferPool, writeBuffer);

                                writeBuffer = newBuffer;
                            }

                            s.CopyTo(lastWritePosition, writeBuffer, start, length - start);

                            // write unchanged chars before writing escaped text
                            writer.Write(writeBuffer, start, length - start);
                        }

                        lastWritePosition = i + 1;
                        if (!isEscapedUnicodeText)
                        {
                            writer.Write(escapedValue);
                        }
                        else
                        {
                            writer.Write(writeBuffer, 0, UnicodeTextLength);
                        }
                    }

                    XDebug.Assert(lastWritePosition != 0);
                    length = s.Length - lastWritePosition;
                    if (length > 0)
                    {
                        if (writeBuffer == null || writeBuffer.Length < length)
                        {
                            writeBuffer = XMemory.EnsureBufferSize(bufferPool, length, writeBuffer);
                        }

                        s.CopyTo(lastWritePosition, writeBuffer, 0, length);

                        // write remaining text
                        writer.Write(writeBuffer, 0, length);
                    }
                }
            }

            // trailing delimiter
            if (appendDelimiters)
            {
                writer.Write(delimiter);
            }
        }

        public string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
        {
            bool[] charEscapeFlags = GetCharEscapeFlags(stringEscapeHandling, delimiter);

            using (StringWriter w = XStrings.CreateStringWriter(value?.Length ?? 16))
            {
                char[] buffer = null;
                WriteEscapedJavaScriptString(w, value, delimiter, appendDelimiters, charEscapeFlags, stringEscapeHandling, null, ref buffer);
                return w.ToString();
            }
        }

        public int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
        {
            for (int i = 0; i != s.Length; i++)
            {
                char c = s[i];

                if (c < charEscapeFlags.Length)
                {
                    if (charEscapeFlags[c])
                    {
                        return i;
                    }
                }
                else if (stringEscapeHandling == StringEscapeHandling.EscapeNonAscii)
                {
                    return i;
                }
                else
                {
                    switch (c)
                    {
                        case '\u0085':
                        case '\u2028':
                        case '\u2029':
                            return i;
                    }
                }
            }

            return -1;
        }


    }
}

