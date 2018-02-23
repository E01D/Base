

#region Licensing
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


namespace Root.Coding.Code.Statics.E01D.Base.Primitives
{
    public class JsonPrimitivesApi
    {
        /// <summary>
        /// Represents JavaScript's boolean value <c>true</c> as a string. This field is read-only.
        /// </summary>
        public readonly string True = "true";

        /// <summary>
        /// Represents JavaScript's boolean value <c>false</c> as a string. This field is read-only.
        /// </summary>
        public readonly string False = "false";

        /// <summary>
        /// Represents JavaScript's <c>null</c> as a string. This field is read-only.
        /// </summary>
        public readonly string Null = "null";

        /// <summary>
        /// Represents JavaScript's <c>undefined</c> as a string. This field is read-only.
        /// </summary>
        public readonly string Undefined = "undefined";

        /// <summary>
        /// Represents JavaScript's positive infinity as a string. This field is read-only.
        /// </summary>
        public readonly string PositiveInfinity = "Infinity";

        /// <summary>
        /// Represents JavaScript's negative infinity as a string. This field is read-only.
        /// </summary>
        public readonly string NegativeInfinity = "-Infinity";

        /// <summary>
        /// Represents JavaScript's <c>NaN</c> as a string. This field is read-only.
        /// </summary>
        public readonly string NaN = "NaN";
    }
}
