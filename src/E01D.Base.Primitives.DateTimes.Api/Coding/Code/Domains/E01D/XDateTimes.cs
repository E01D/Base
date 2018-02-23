using System;
using System.Globalization;
using System.IO;
using System.Xml;
using Root.Coding.Code.Api.E01D.Base.Primitives;
using Root.Coding.Code.Enums.E01D.Core.DateTimes;
using Root.Coding.Code.Models.E01D.Base.Primitives.DateTimes;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XDateTimes
    {
        public static DateTimeApi Api { get; set; } = new DateTimeApi();

        public static TimeSpan GetUtcOffset(DateTime d)
        {
            return Api.GetUtcOffset(d);
        }

#if !(PORTABLE40 || PORTABLE) || NETSTANDARD1_3
        public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
        {
            return Api.ToSerializationMode(kind);
        }
#else
        public static string ToDateTimeFormat(DateTimeKind kind)
        {
            return Api.ToDateTimeFormat(kind);
        }
#endif

        public static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
        {
            return Api.EnsureDateTime(value, timeZone);
        }

        public static DateTime SwitchToLocalTime(DateTime value)
        {
            return Api.SwitchToLocalTime(value);
        }

        public static DateTime SwitchToUtcTime(DateTime value)
        {
            return Api.SwitchToUtcTime(value);
        }

        public static long ToUniversalTicks(DateTime dateTime)
        {
            return Api.ToUniversalTicks(dateTime);
        }

        public static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
        {
            return Api.ToUniversalTicks(dateTime, offset);
        }

        public static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
        {
            return Api.ConvertDateTimeToJavaScriptTicks(dateTime, offset);
        }

        public static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
        {
            return Api.ConvertDateTimeToJavaScriptTicks(dateTime);
        }

        public static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
        {
            return Api.ConvertDateTimeToJavaScriptTicks(dateTime, convertToUtc);
        }

        public static long UniversialTicksToJavaScriptTicks(long universialTicks)
        {
            return Api.UniversialTicksToJavaScriptTicks(universialTicks);
        }

        public static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
        {
            return Api.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
        }

        #region Parse
        public static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
        {
            return Api.TryParseDateTimeIso(text, dateTimeZoneHandling, out dt);
        }


        public static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
        {
            return Api.TryParseDateTimeOffsetIso(text, out dt);
        }


        public static DateTime CreateDateTime(DateTimeParse dateTimeParser)
        {
            return Api.CreateDateTime(dateTimeParser);
        }

        public static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
        {
            return Api.TryParseDateTime(s, dateTimeZoneHandling, dateFormatString, culture, out dt);
        }

        public static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
        {
            return Api.TryParseDateTime(s, dateTimeZoneHandling, dateFormatString, culture, out dt);
        }


        public static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
        {
            return Api.TryParseDateTimeOffset(s, dateFormatString, culture, out dt);
        }

        public static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
        {
            return Api.TryParseDateTimeOffset(s, dateFormatString, culture, out dt);
        }


        public static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
        {
            return Api.TryParseMicrosoftDate(text, out ticks, out offset, out kind);
        }

        public static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
        {
            return Api.TryParseDateTimeMicrosoft(text, dateTimeZoneHandling, out dt);

        }

        public static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
        {
            return Api.TryParseDateTimeExact(text, dateTimeZoneHandling, dateFormatString, culture, out dt);
        }


        public static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
        {
            return Api.TryParseDateTimeOffsetMicrosoft(text, out dt);
        }

        public static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
        {
            return Api.TryParseDateTimeOffsetExact(text, dateFormatString, culture, out dt);
        }


        public static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
        {
            return Api.TryReadOffset(offsetText, startIndex, out offset);
        }
        #endregion

        #region Write
        public static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
        {
            Api.WriteDateTimeString(writer, value, format, formatString, culture);
        }

        public static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
        {
            return Api.WriteDateTimeString(chars, start, value, offset, kind, format);
        }

        public static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
        {
            return Api.WriteDefaultIsoDate(chars, start, dt);
        }

        public static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
        {
            Api.CopyIntToCharArray(chars, start, value, digits);
        }

        public static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
        {
            return Api.WriteDateTimeOffset(chars, start, offset, format);
        }


        public static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture)
        {
            Api.WriteDateTimeOffsetString(writer, value, format, formatString, culture);
        }

        #endregion

        public static void GetDateValues(DateTime td, out int year, out int month, out int day)
        {
            Api.GetDateValues(td, out year, out month, out day);
        }
    }
}
