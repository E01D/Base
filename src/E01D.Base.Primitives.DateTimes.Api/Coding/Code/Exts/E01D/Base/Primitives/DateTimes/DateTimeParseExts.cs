using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Primitives.DateTimes;

namespace Root.Coding.Code.Exts.E01D.Base.Primitives.DateTimes
{
    public static class DateTimeParseExts
    {
        public static bool Parse(this DateTimeParse parse, char[] text, int startIndex, int length)
        {
            return XDateTimes.Api.Parsing.Parse(parse, text, startIndex, length);
        }

        public static bool ParseDate(this DateTimeParse parse, int start)
        {
            return XDateTimes.Api.Parsing.ParseDate(parse, start);
        }

        public static bool ParseTimeAndZoneAndWhitespace(this DateTimeParse parse, int start)
        {
            return XDateTimes.Api.Parsing.ParseTimeAndZoneAndWhitespace(parse, start);
        }

        public static bool ParseTime(this DateTimeParse parse, ref int start)
        {
            return XDateTimes.Api.Parsing.ParseTime(parse, ref start);
        }

        public static bool ParseZone(this DateTimeParse parse, int start)
        {
            return XDateTimes.Api.Parsing.ParseZone(parse, start);
        }

        public static bool Parse4Digit(this DateTimeParse parse, int start, out int num)
        {
            return XDateTimes.Api.Parsing.Parse4Digit(parse, start, out num);
        }

        public static bool Parse2Digit(this DateTimeParse parse, int start, out int num)
        {
            return XDateTimes.Api.Parsing.Parse2Digit(parse, start, out num);
        }

        public static bool ParseChar(this DateTimeParse parse, int start, char ch)
        {
            return XDateTimes.Api.Parsing.ParseChar(parse, start, ch);
        }
    }
}
