using Root.Coding.Code.Enums.E01D.Core.DateTimes;

namespace Root.Coding.Code.Models.E01D.Base.Primitives.DateTimes
{
    public class DateTimeParse
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public int Fraction { get; set; }
        public int ZoneHour { get; set; }
        public int ZoneMinute { get; set; }
        public ParserTimeZone Zone { get; set; }

        public char[] Text { get; set; }
        public int End { get; set; }
    }
}
