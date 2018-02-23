#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using Root.Coding.Code.Api.E01D.Base.Primitives;
using Root.Coding.Code.Api.E01D.Memory;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XStrings
    {
        public static StringApi Api { get; set; } = new StringApi();

        public const string CarriageReturnLineFeed = "\r\n";
        public const string Empty = "";
        public const char CarriageReturn = '\r';
        public const char LineFeed = '\n';
        public const char Tab = '\t';

        public static bool EndsWith(string pathValue, char charValue)
        {
            return Api.EndsWith(pathValue, charValue);
        }

        public static string FormatWith(string format, IFormatProvider provider, object arg0)
        {
            return Api.FormatWith(format, provider, arg0);
        }

        public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1)
        {
            return Api.FormatWith(format, provider, arg0, arg1);
        }

        public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2)
        {
            return Api.FormatWith(format, provider, arg0, arg1, arg2);
        }

        public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
        {
            return Api.FormatWith(format, provider, arg0, arg1, arg2, arg3);
        }

        private static string FormatWith(string format, IFormatProvider provider, params object[] args)
        {
            return Api.FormatWith(format, provider, args);
        }

        /// <summary>
        /// Determines whether the string is all white space. Empty string will return <c>false</c>.
        /// </summary>
        /// <param name="s">The string to test whether it is all white space.</param>
        /// <returns>
        /// 	<c>true</c> if the string is all white space; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWhiteSpace(string s)
        {
            return Api.IsWhiteSpace(s);
        }

        public static StringWriter CreateStringWriter(int capacity)
        {
            return Api.CreateStringWriter(capacity);
        }

        public static void ToCharAsUnicode(char c, char[] buffer)
        {
            Api.ToCharAsUnicode(c, buffer);
        }

        public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
        {
            return Api.ForgivingCaseSensitiveFind(source, valueSelector, testValue);
        }

        public static string ToCamelCase(string s)
        {
            return Api.ToCamelCase(s);
        }

        public static string ToSnakeCase(string s)
        {
            return Api.ToSnakeCase(s);
        }

        public static bool IsHighSurrogate(char c)
        {
            return Api.IsHighSurrogate(c);
        }

        public static bool IsLowSurrogate(char c)
        {
            return Api.IsLowSurrogate(c);
        }

        public static bool StartsWith(string source, char value)
        {
            return Api.StartsWith(source, value);
        }

        public static StringBuffer StringBuffer(ArrayPoolApi_I<char> bufferPool, int initialSize)
        {
            return Api.StringBuffers.StringBuffer(bufferPool, initialSize);
        }

        public static StringBuffer StringBuffer(char[] internalBuffer)
        {
            return Api.StringBuffers.StringBuffer(internalBuffer);
        }

        public static StringReference StringReference(char[] chars, int startIndex, int length)
        {
            return Api.StringReferences.StringReference(chars, startIndex, length);
        }

        public static string Trim(string s, int start, int length)
        {
            return Api.Trim(s, start, length);
        }
    }
}
