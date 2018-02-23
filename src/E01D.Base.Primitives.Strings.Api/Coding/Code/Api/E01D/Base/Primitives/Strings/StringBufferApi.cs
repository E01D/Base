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
using Root.Coding.Code.Api.E01D.Memory;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Api.E01D.Base.Primitives.Strings
{
    public class StringBufferApi
    {
       

        public void Append(StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool, char value)
        {
            // test if the buffer array is large enough to take the value
            if (stringBuffer.Position == stringBuffer.Buffer.Length)
            {
                EnsureSize(stringBuffer, bufferPool, 1);
            }

            // set value and increment poisition
            stringBuffer.Buffer[stringBuffer.Position++] = value;
        }

        public void Append(StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool, char[] buffer, int startIndex, int count)
        {
            if (stringBuffer.Position + count >= stringBuffer.Buffer.Length)
            {
                EnsureSize(stringBuffer, bufferPool, count);
            }

            Array.Copy(buffer, startIndex, stringBuffer.Buffer, stringBuffer.Position, count);

            stringBuffer.Position += count;
        }

        public void Clear(StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool)
        {
            if (stringBuffer.Buffer != null)
            {
                XMemory.ReturnBuffer(bufferPool, stringBuffer.Buffer);
                stringBuffer.Buffer = null;
            }
            stringBuffer.Position = 0;
        }

        public string ConvertToString(StringBuffer stringBuffer)
        {
            return ConvertToString(stringBuffer, 0, stringBuffer.Position);
        }

        public string ConvertToString(StringBuffer stringBuffer, int start, int length)
        {
            // TODO: validation
            return new string(stringBuffer.Buffer, start, length);
        }

        public void EnsureSize(StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool, int appendLength)
        {
            char[] newBuffer = XMemory.RentBuffer(bufferPool, (stringBuffer.Position + appendLength) * 2);

            if (stringBuffer.Buffer != null)
            {
                Array.Copy(stringBuffer.Buffer, newBuffer, stringBuffer.Position);
                XMemory.ReturnBuffer(bufferPool, stringBuffer.Buffer);
            }

            stringBuffer.Buffer = newBuffer;
        }

        public bool IsEmpty(StringBuffer stringBuffer)
        {
            return stringBuffer.Buffer == null;
        }

        public StringBuffer StringBuffer(ArrayPoolApi_I<char> bufferPool, int initalSize)
        {
            return StringBuffer(XMemory.RentBuffer(bufferPool, initalSize));
        }

        public StringBuffer StringBuffer(char[] internalBuffer)
        {
            return new StringBuffer
            {
                Buffer = internalBuffer,
                Position = 0
            };
        }

        
    }
}
