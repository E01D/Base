using System;

namespace Root.Coding.Code.Api.E01D.Core.Primitives
{
    public class DateTimeApi
    {
        private static readonly DateTime TheDate19700101 = new DateTime(1970, 1, 1);

        public DateTime Add(TimeSpan value)
        {
            return (DateTime.UtcNow + value);
        }

        public DateTime ConvertFromEpochTime(long seconds)
        {
            return TheDate19700101.AddSeconds(seconds);
        }

        public DateTime ConvertFromEpochTime(decimal seconds)
        {
            return TheDate19700101.AddMilliseconds((long)(seconds * 1000));
        }

        /// <summary>
        /// Converts a .NET Framework datetime to a unix 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public long ConvertToEpochTime(DateTime dateTime)
        {
            return (long)(dateTime - TheDate19700101).TotalSeconds;
        }
    }
}
