using System;

namespace Root.Coding.Code.Exts.E01D.Core.Primitives
{
    public static class TimespanExts
    {
        public static DateTime FromNow(this TimeSpan value)
        {
            return new DateTime((DateTime.Now + value).Ticks);
        }
    }
}
