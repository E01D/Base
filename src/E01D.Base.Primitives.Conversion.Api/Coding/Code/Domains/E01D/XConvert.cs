using System;
using Root.Coding.Code.Api.E01D.Base.Primitives;
using Root.Coding.Code.Enums.E01D.Parsing;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XConvert
    {
        public static ConversionApi Api { get; set; } = new ConversionApi();

        public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
        {
            return Api.TryHexTextToInt(text, start, end, out value);
        }

        public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
        {
            return Api.Int64TryParse(chars, start, length, out value);
        }

        public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
        {
            return Api.Int32TryParse(chars, start, length, out value);
        }

        public static bool TryConvertGuid(string s, out Guid g)
        {
            return Api.TryConvertGuid(s, out g);
        }
    }
}
