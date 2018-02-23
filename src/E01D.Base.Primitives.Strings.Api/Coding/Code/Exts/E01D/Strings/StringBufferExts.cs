using Root.Coding.Code.Api.E01D.Memory;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Exts.E01D.Strings
{
    public static class StringBufferExts
    {
        public static void Append(this StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool, char value)
        {
            XStrings.Api.StringBuffers.Append(stringBuffer, bufferPool, value);
        }

        public static void Append(this StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool, char[] buffer, int startIndex, int count)
        {
            XStrings.Api.StringBuffers.Append(stringBuffer, bufferPool, buffer, startIndex, count);
        }

        public static void Clear(this StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool)
        {
            XStrings.Api.StringBuffers.Clear(stringBuffer, bufferPool);
        }

        public static string ConvertToString(this StringBuffer stringBuffer)
        {
            return XStrings.Api.StringBuffers.ConvertToString(stringBuffer);
        }

        public static string ConvertToString(this StringBuffer stringBuffer, int start, int length)
        {
            return XStrings.Api.StringBuffers.ConvertToString(stringBuffer, start, length);
        }

        public static void EnsureSize(this StringBuffer stringBuffer, ArrayPoolApi_I<char> bufferPool, int appendLength)
        {
            XStrings.Api.StringBuffers.EnsureSize(stringBuffer, bufferPool, appendLength);
        }

        public static bool IsEmpty(this StringBuffer stringBuffer)
        {
            return XStrings.Api.StringBuffers.IsEmpty(stringBuffer);
        }

        
    }
}
