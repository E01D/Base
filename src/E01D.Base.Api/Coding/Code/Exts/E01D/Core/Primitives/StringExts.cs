using System;
using Root.Coding.Code.Domains.E01D.Core;

namespace Root.Coding.Code.Exts.E01D.Core.Primitives
{
    public static class StringExts
    {
        public static bool HasValue(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        public static decimal? ParseDecimalOrNull(this string input)
        {
            return XBase.Api.Primitives.String.ParseDecimalOrNull(input);
        }

        public static long ParseInt64OrZero(this string settingValue)
        {
            return XBase.Api.Primitives.String.ParseInt64OrZero(settingValue);
        }

        public static long? ParseInt64OrNull(this string input)
        {
            return XBase.Api.Primitives.String.ParseInt64OrNull(input);
        }
        public static DateTime? ParseDateTimeOrNull(this string input)
        {
            return XBase.Api.Primitives.String.ParseDateTimeOrNull(input);
        }
    }
}
