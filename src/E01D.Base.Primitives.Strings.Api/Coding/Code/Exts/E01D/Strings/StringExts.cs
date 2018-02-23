using System;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Strings
{
    public static class StringExts
    {
        public static string FormatWith(this string format, IFormatProvider provider, object arg0)
        {
            return XStrings.FormatWith(format, provider, arg0);
        }

        public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
        {
            return XStrings.FormatWith(format, provider, arg0, arg1);
        }

        public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
        {
            return XStrings.FormatWith(format, provider, arg0, arg1, arg2);
        }

        public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
        {
            return XStrings.FormatWith(format, provider, arg0, arg1, arg2, arg3);
        }

        public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
        {
            return XStrings.FormatWith(format, provider, args);
        }

        /// <summary>
        /// Determines whether the string is all white space. Empty string will return <c>false</c>.
        /// </summary>
        /// <param name="s">The string to test whether it is all white space.</param>
        /// <returns>
        /// 	<c>true</c> if the string is all white space; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWhiteSpace(this string s)
        {
            return XStrings.IsWhiteSpace(s);
        }

        public static string ToCamelCase(this string s)
        {
            return XStrings.ToCamelCase(s);
        }

        public static string ToSnakeCase(this string s)
        {
            return XStrings.ToSnakeCase(s);
        }

        public static bool StartsWith(this string source, char value)
        {
            return XStrings.StartsWith(source, value);
        }

        public static bool EndsWith(this string source, char value)
        {
            return XStrings.EndsWith(source, value);
        }

        public static string Trim(this string s, int start, int length)
        {
            return XStrings.Trim(s, start, length);
        }
    }
}
