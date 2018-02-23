using System;

namespace Root.Coding.Code.Api.E01D.Core.Primitives
{
    public class StringApi
    {
        public Strings.StringRequirements Requirements { get; set; } = new Strings.StringRequirements();

        public Strings.StringValidation Validation { get; set; } = new Strings.StringValidation();

        public Strings.StringUrlsApi Urls { get; set; } = new Strings.StringUrlsApi();

        /// <summary>
        /// Determines if a string is not null or empty.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool HasValue(string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        public decimal? ParseDecimalOrNull(string input)
        {
            if (input == null) return null;

            decimal x;

            if (decimal.TryParse(input, out x))
            {
                return x;
            }

            return null;
        }

        public long ParseInt64OrZero(string settingValue)
        {
            if (settingValue == null) return 0;

            long lastIssuedId;
            
            if (!long.TryParse(settingValue, out lastIssuedId))
            {
                lastIssuedId = 0;
            }
            
            return lastIssuedId;
        }

        public long? ParseInt64OrNull(string input)
        {
            if (input == null) return null;

            long x;

            if (long.TryParse(input, out x))
            {
                return x;
            }

            return null;
        }

        public DateTime? ParseDateTimeOrNull(string input)
        {
            if (input == null) return null;

            DateTime x;

            if (DateTime.TryParse(input, out x))
            {
                return x;
            }

            return null;
        }

        private static readonly uint[] _lookup32 = CreateLookup32();

        private static uint[] CreateLookup32()
        {
            var result = new uint[256];
            for (int i = 0; i < 256; i++)
            {
                string s = i.ToString("X2");
                result[i] = ((uint)s[0]) + ((uint)s[1] << 16);
            }
            return result;
        }

        public string ConvertBytesToHex(byte[] bytes)
        {
            var lookup32 = _lookup32;
            var result = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                var val = lookup32[bytes[i]];
                result[2 * i] = (char)val;
                result[2 * i + 1] = (char)(val >> 16);
            }
            return new string(result);
        }
    }
}
