using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Root.Code.Domains;
using Root.Coding.Code.Api.E01D.Base.Primitives.Strings;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Strings;

namespace Root.Coding.Code.Api.E01D.Base.Primitives
{
    public class StringApi
    {
        public StringBufferApi StringBuffers { get; set; } = new StringBufferApi();

        public StringReferenceApi StringReferences { get; set; } = new StringReferenceApi();

        //public Base64EncodingApi Base64Encoding { get; set; } = new Base64EncodingApi();


        public string CarriageReturnLineFeed = "\r\n";
        public string Empty = "";
        public char CarriageReturn = '\r';
        public char LineFeed = '\n';
        public char Tab = '\t';

        public bool EndsWith(string pathValue, char charValue)
        {
            if (string.IsNullOrEmpty(pathValue) || pathValue.Length > 0) return false;

            return pathValue[pathValue.Length - 1] == charValue;
        }

        public string FormatWith(string format, IFormatProvider provider, object arg0)
        {
            return FormatWith(format, provider, new[] { arg0 });
        }

        public string FormatWith(string format, IFormatProvider provider, object arg0, object arg1)
        {
            return FormatWith(format, provider, new[] { arg0, arg1 });
        }

        public string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2)
        {
            return FormatWith(format, provider, new[] { arg0, arg1, arg2 });
        }

        public string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
        {
            return FormatWith(format, provider, new[] { arg0, arg1, arg2, arg3 });
        }

        private string FormatWith(string format, IFormatProvider provider, params object[] args)
        {
            // leave this a private to force code to use an explicit overload
            // avoids stack memory being reserved for the object array
            XValidation.ArgumentNotNull(format, nameof(format));

            return string.Format(provider, format, args);
        }

        /// <summary>
        /// Determines whether the string is all white space. Empty string will return <c>false</c>.
        /// </summary>
        /// <param name="s">The string to test whether it is all white space.</param>
        /// <returns>
        /// 	<c>true</c> if the string is all white space; otherwise, <c>false</c>.
        /// </returns>
        public bool IsWhiteSpace(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (s.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public StringWriter CreateStringWriter(int capacity)
        {
            StringBuilder sb = new StringBuilder(capacity);
            StringWriter sw = new StringWriter(sb, CultureInfo.InvariantCulture);

            return sw;
        }

        public void ToCharAsUnicode(char c, char[] buffer)
        {
            buffer[0] = '\\';
            buffer[1] = 'u';
            buffer[2] = XMath.IntToHex((c >> 12) & '\x000f');
            buffer[3] = XMath.IntToHex((c >> 8) & '\x000f');
            buffer[4] = XMath.IntToHex((c >> 4) & '\x000f');
            buffer[5] = XMath.IntToHex(c & '\x000f');
        }

        public TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (valueSelector == null)
            {
                throw new ArgumentNullException(nameof(valueSelector));
            }

            IEnumerable<TSource> caseInsensitiveResults = source.Where(s => string.Equals(valueSelector(s), testValue, StringComparison.OrdinalIgnoreCase));
            if (caseInsensitiveResults.Count() <= 1)
            {
                return caseInsensitiveResults.SingleOrDefault();
            }
            else
            {
                // multiple results returned. now filter using case sensitivity
                IEnumerable<TSource> caseSensitiveResults = source.Where(s => string.Equals(valueSelector(s), testValue, StringComparison.Ordinal));
                return caseSensitiveResults.SingleOrDefault();
            }
        }

        public string ToCamelCase(string s)
        {
            if (string.IsNullOrEmpty(s) || !char.IsUpper(s[0]))
            {
                return s;
            }

            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 1 && !char.IsUpper(chars[i]))
                {
                    break;
                }

                bool hasNext = (i + 1 < chars.Length);
                if (i > 0 && hasNext && !char.IsUpper(chars[i + 1]))
                {
                    break;
                }

                char c;
#if HAVE_CHAR_TO_STRING_WITH_CULTURE
                c = char.ToLower(chars[i], CultureInfo.InvariantCulture);
#else
                c = char.ToLowerInvariant(chars[i]);
#endif
                chars[i] = c;
            }

            return new string(chars);
        }



        public string ToSnakeCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            StringBuilder sb = new StringBuilder();
            SnakeCaseState state = SnakeCaseState.Start;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (state != SnakeCaseState.Start)
                    {
                        state = SnakeCaseState.NewWord;
                    }
                }
                else if (char.IsUpper(s[i]))
                {
                    switch (state)
                    {
                        case SnakeCaseState.Upper:
                            bool hasNext = (i + 1 < s.Length);
                            if (i > 0 && hasNext)
                            {
                                char nextChar = s[i + 1];
                                if (!char.IsUpper(nextChar) && nextChar != '_')
                                {
                                    sb.Append('_');
                                }
                            }
                            break;
                        case SnakeCaseState.Lower:
                        case SnakeCaseState.NewWord:
                            sb.Append('_');
                            break;
                    }

                    char c;
#if HAVE_CHAR_TO_LOWER_WITH_CULTURE
                    c = char.ToLower(s[i], CultureInfo.InvariantCulture);
#else
                    c = char.ToLowerInvariant(s[i]);
#endif
                    sb.Append(c);

                    state = SnakeCaseState.Upper;
                }
                else if (s[i] == '_')
                {
                    sb.Append('_');
                    state = SnakeCaseState.Start;
                }
                else
                {
                    if (state == SnakeCaseState.NewWord)
                    {
                        sb.Append('_');
                    }

                    sb.Append(s[i]);
                    state = SnakeCaseState.Lower;
                }
            }

            return sb.ToString();
        }

        public bool IsHighSurrogate(char c)
        {
#if HAVE_UNICODE_SURROGATE_DETECTION
            return char.IsHighSurrogate(c);
#else
            return (c >= 55296 && c <= 56319);
#endif
        }

        public bool IsLowSurrogate(char c)
        {
#if HAVE_UNICODE_SURROGATE_DETECTION
            return char.IsLowSurrogate(c);
#else
            return (c >= 56320 && c <= 57343);
#endif
        }

        public bool StartsWith(string source, char value)
        {
            return (source.Length > 0 && source[0] == value);
        }



        public string Trim(string s, int start, int length)
        {
            // References: https://referencesource.microsoft.com/#mscorlib/system/string.cs,2691
            // https://referencesource.microsoft.com/#mscorlib/system/string.cs,1226
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            if (start < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(start));
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            int end = start + length - 1;
            if (end >= s.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            for (; start < end; start++)
            {
                if (!char.IsWhiteSpace(s[start]))
                {
                    break;
                }
            }
            for (; end >= start; end--)
            {
                if (!char.IsWhiteSpace(s[end]))
                {
                    break;
                }
            }
            return s.Substring(start, end - start + 1);
        }
    }
}
