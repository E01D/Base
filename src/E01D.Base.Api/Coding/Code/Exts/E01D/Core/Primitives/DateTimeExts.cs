using System;
using Root.Coding.Code.Domains.E01D.Core;

namespace Root.Coding.Code.Exts.E01D.Core.Primitives
{
    public static class DateTimeExts
    {
        public static DateTime ConvertFromEpochTime(this long seconds)
        {
            return XBase.Api.Primitives.DateTime.ConvertFromEpochTime(seconds);
        }

        public static DateTime ConvertFromEpochTime(this decimal seconds)
        {
            return XBase.Api.Primitives.DateTime.ConvertFromEpochTime(seconds);
        }

        public static long ConvertToEpochTime(this DateTime dateTime)
        {
            return XBase.Api.Primitives.DateTime.ConvertToEpochTime(dateTime);
        }


    }
}
