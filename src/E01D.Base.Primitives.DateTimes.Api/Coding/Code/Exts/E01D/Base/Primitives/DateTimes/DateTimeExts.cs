using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Core.DateTimes;

namespace Root.Coding.Code.Exts.E01D.Base.Primitives.DateTimes
{
    public static class DateTimeExts
    {
        public static TimeSpan GetUtcOffset(this DateTime d)
        {
            return XDateTimes.Api.GetUtcOffset(d);
        }

        public static DateTime EnsureDateTime(this DateTime value, DateTimeZoneHandling timeZone)
        {
            return XDateTimes.Api.EnsureDateTime(value, timeZone);
        }

        public static DateTime SwitchToLocalTime(this DateTime value)
        {
            return XDateTimes.Api.SwitchToLocalTime(value);
        }

        public static DateTime SwitchToUtcTime(this DateTime value)
        {
            return XDateTimes.Api.SwitchToUtcTime(value);
        }

        public static long ToUniversalTicks(this DateTime dateTime)
        {
            return XDateTimes.Api.ToUniversalTicks(dateTime);
        }

        public static long ToUniversalTicks(this DateTime dateTime, TimeSpan offset)
        {
            return XDateTimes.Api.ToUniversalTicks(dateTime, offset);
        }

        public static long ConvertDateTimeToJavaScriptTicks(this DateTime dateTime, TimeSpan offset)
        {
            return XDateTimes.Api.ConvertDateTimeToJavaScriptTicks(dateTime, offset);
        }

        public static long ConvertDateTimeToJavaScriptTicks(this DateTime dateTime)
        {
            return XDateTimes.Api.ConvertDateTimeToJavaScriptTicks(dateTime);
        }

        public static long ConvertDateTimeToJavaScriptTicks(this DateTime dateTime, bool convertToUtc)
        {
            return XDateTimes.Api.ConvertDateTimeToJavaScriptTicks(dateTime, convertToUtc);
        }
    }
}
