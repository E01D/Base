﻿#region License
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

using Root.Code.Api.E01D.Core;



namespace Root.Code.Domains
{
    public static class XMath
    {
        public static MathApi Api { get; set; } = new MathApi();

        public static decimal RoundDownToNearestDecimal(decimal number, decimal threshold)
        {
            return Api.RoundDownToNearestDecimal(number, threshold);
        }

        public static int IntLength(ulong i)
        {
            return Api.General.IntLength(i);
        }

        public static char IntToHex(int n)
        {
            return Api.General.IntToHex(n);
        }

        public static int? Min(int? val1, int? val2)
        {
            return Api.General.Min(val1, val2);
        }

        public static int? Max(int? val1, int? val2)
        {
            return Api.General.Max(val1, val2);
        }

        public static double? Max(double? val1, double? val2)
        {
            return Api.General.Max(val1, val2);
        }

        public static bool ApproxEquals(double d1, double d2)
        {
            return Api.General.ApproxEquals(d1, d2);
        }
    }
}
