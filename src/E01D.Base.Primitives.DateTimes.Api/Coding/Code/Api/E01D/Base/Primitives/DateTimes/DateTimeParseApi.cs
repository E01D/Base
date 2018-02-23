using System;
using Root.Coding.Code.Enums.E01D.Core.DateTimes;
using Root.Coding.Code.Models.E01D.Base.Primitives.DateTimes;

namespace Root.Coding.Code.Api.E01D.Base.Primitives.DateTimes
{
    public class DateTimeParseApi
    {
        private static readonly int[] Power10;

        private static readonly int Lzyyyy;
        private static readonly int Lzyyyy_;
        private static readonly int Lzyyyy_MM;
        private static readonly int Lzyyyy_MM_;
        private static readonly int Lzyyyy_MM_dd;
        private static readonly int Lzyyyy_MM_ddT;
        private static readonly int LzHH;
        private static readonly int LzHH_;
        private static readonly int LzHH_mm;
        private static readonly int LzHH_mm_;
        private static readonly int LzHH_mm_ss;
        private static readonly int Lz_;
        private static readonly int Lz_zz;

        private const short MaxFractionDigits = 7;

        static DateTimeParseApi()
        {
            Power10 = new[] { -1, 10, 100, 1000, 10000, 100000, 1000000 };

            Lzyyyy = "yyyy".Length;
            Lzyyyy_ = "yyyy-".Length;
            Lzyyyy_MM = "yyyy-MM".Length;
            Lzyyyy_MM_ = "yyyy-MM-".Length;
            Lzyyyy_MM_dd = "yyyy-MM-dd".Length;
            Lzyyyy_MM_ddT = "yyyy-MM-ddT".Length;
            LzHH = "HH".Length;
            LzHH_ = "HH:".Length;
            LzHH_mm = "HH:mm".Length;
            LzHH_mm_ = "HH:mm:".Length;
            LzHH_mm_ss = "HH:mm:ss".Length;
            Lz_ = "-".Length;
            Lz_zz = "-zz".Length;
        }

        public bool Parse(DateTimeParse parse, char[] text, int startIndex, int length)
        {
            parse.Text = text;
            parse.End = startIndex + length;

            if (ParseDate(parse, startIndex) && ParseChar(parse, Lzyyyy_MM_dd + startIndex, 'T') && ParseTimeAndZoneAndWhitespace(parse, Lzyyyy_MM_ddT + startIndex))
            {
                return true;
            }

            return false;
        }

        public bool ParseDate(DateTimeParse parse, int start)
        {
            int year = 0;
            int month = 0;
            int day = 0;

            var result = (Parse4Digit(parse, start, out year)
                    && 1 <= year
                    && ParseChar(parse, start + Lzyyyy, '-')
                    && Parse2Digit(parse, start + Lzyyyy_, out month)
                    && 1 <= month
                    && month <= 12
                    && ParseChar(parse, start + Lzyyyy_MM, '-')
                    && Parse2Digit(parse, start + Lzyyyy_MM_, out day)
                    && 1 <= day
                    && day <= DateTime.DaysInMonth(year, month));

            parse.Year = year;
            parse.Month = month;
            parse.Day = day;

            return result;
        }

        public bool ParseTimeAndZoneAndWhitespace(DateTimeParse parse, int start)
        {
            return (ParseTime(parse, ref start) && ParseZone(parse, start));
        }

        public bool ParseTime(DateTimeParse parse, ref int start)
        {
            int hour = 0;
            int minute = 0;
            int second = 0;

            if (!(Parse2Digit(parse, start, out hour)
                  && hour <= 24
                  && ParseChar(parse, start + LzHH, ':')
                  && Parse2Digit(parse, start + LzHH_, out minute)
                  && minute < 60
                  && ParseChar(parse, start + LzHH_mm, ':')
                  && Parse2Digit(parse, start + LzHH_mm_, out second)
                  && second < 60
                  && (hour != 24 || (minute == 0 && second == 0)))) // hour can be 24 if minute/second is zero)
            {
                parse.Hour = hour;
                parse.Minute = minute;
                parse.Second = second;

                return false;
            }

            parse.Hour = hour;
            parse.Minute = minute;
            parse.Second = second;

            start += LzHH_mm_ss;
            if (ParseChar(parse, start, '.'))
            {
                parse.Fraction = 0;
                int numberOfDigits = 0;

                while (++start < parse.End && numberOfDigits < MaxFractionDigits)
                {
                    int digit = parse.Text[start] - '0';
                    if (digit < 0 || digit > 9)
                    {
                        break;
                    }

                    parse.Fraction = (parse.Fraction * 10) + digit;

                    numberOfDigits++;
                }

                if (numberOfDigits < MaxFractionDigits)
                {
                    if (numberOfDigits == 0)
                    {
                        return false;
                    }

                    parse.Fraction *= Power10[MaxFractionDigits - numberOfDigits];
                }

                if (parse.Hour == 24 && parse.Fraction != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ParseZone(DateTimeParse parse, int start)
        {
            if (start < parse.End)
            {
                char ch = parse.Text[start];
                if (ch == 'Z' || ch == 'z')
                {
                    parse.Zone = ParserTimeZone.Utc;
                    start++;
                }
                else
                {
                    int zoneHour = 0;

                    if (start + 2 < parse.End
                        && Parse2Digit(parse, start + Lz_, out zoneHour)
                        && zoneHour <= 99)
                    {
                        switch (ch)
                        {
                            case '-':
                                parse.Zone = ParserTimeZone.LocalWestOfUtc;
                                start += Lz_zz;
                                break;

                            case '+':
                                parse.Zone = ParserTimeZone.LocalEastOfUtc;
                                start += Lz_zz;
                                break;
                        }
                    }

                    if (start < parse.End)
                    {
                        int zoneMinute = 0;

                        if (ParseChar(parse, start, ':'))
                        {
                            start += 1;

                            if (start + 1 < parse.End
                                && Parse2Digit(parse, start, out zoneMinute)
                                && zoneMinute <= 99)
                            {
                                start += 2;
                            }
                        }
                        else
                        {
                            if (start + 1 < parse.End
                                && Parse2Digit(parse, start, out zoneMinute)
                                && zoneMinute <= 99)
                            {
                                start += 2;
                            }
                        }

                        parse.ZoneMinute = zoneMinute;
                    }
                }
            }

            return (start == parse.End);
        }

        public bool Parse4Digit(DateTimeParse parse, int start, out int num)
        {
            if (start + 3 < parse.End)
            {
                int digit1 = parse.Text[start] - '0';
                int digit2 = parse.Text[start + 1] - '0';
                int digit3 = parse.Text[start + 2] - '0';
                int digit4 = parse.Text[start + 3] - '0';
                if (0 <= digit1 && digit1 < 10
                    && 0 <= digit2 && digit2 < 10
                    && 0 <= digit3 && digit3 < 10
                    && 0 <= digit4 && digit4 < 10)
                {
                    num = (((((digit1 * 10) + digit2) * 10) + digit3) * 10) + digit4;
                    return true;
                }
            }
            num = 0;
            return false;
        }

        public bool Parse2Digit(DateTimeParse parse, int start, out int num)
        {
            if (start + 1 < parse.End)
            {
                int digit1 = parse.Text[start] - '0';
                int digit2 = parse.Text[start + 1] - '0';
                if (0 <= digit1 && digit1 < 10
                    && 0 <= digit2 && digit2 < 10)
                {
                    num = (digit1 * 10) + digit2;
                    return true;
                }
            }
            num = 0;
            return false;
        }

        public bool ParseChar(DateTimeParse parse, int start, char ch)
        {
            return (start < parse.End && parse.Text[start] == ch);
        }
    }
}
