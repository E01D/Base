using System.IO;
using Root.Coding.Code.Api.E01D.Javascript;
using Root.Coding.Code.Api.E01D.Memory;
using Root.Coding.Code.Enums.Javascript.Strings;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XJavascriptStrings
    {
        public static JavascriptStringsApi Api { get; set; } = new JavascriptStringsApi();

        public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
        {
            return Api.GetCharEscapeFlags(stringEscapeHandling, quoteChar);
        }

        public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
        {
            return Api.ShouldEscapeJavaScriptString(s, charEscapeFlags);
        }

        public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter,
            bool appendDelimiters,
            bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, ArrayPoolApi_I<char> bufferPool,
            ref char[] writeBuffer)
        {
            Api.WriteEscapedJavaScriptString(writer, s, delimiter, appendDelimiters, charEscapeFlags,
                stringEscapeHandling, bufferPool, ref writeBuffer);
        }

        public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters,
            StringEscapeHandling stringEscapeHandling)
        {
            return Api.ToEscapedJavaScriptString(value, delimiter, appendDelimiters, stringEscapeHandling);
        }

        public static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
        {
            return Api.FirstCharToEscape(s, charEscapeFlags, stringEscapeHandling);
        }
    }
}
