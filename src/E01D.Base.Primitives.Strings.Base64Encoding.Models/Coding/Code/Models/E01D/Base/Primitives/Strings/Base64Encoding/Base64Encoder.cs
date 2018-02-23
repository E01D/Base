using System.IO;
using Root.Coding.Code.Constants.E01D.Base.Primitives.Strings.Base64Encoding;

namespace Root.Coding.Code.Models.E01D.Base.Primitives.Strings.Base64Encoding
{
    public class Base64Encoder
    {
        public char[] CharsLine { get; set; } = new char[Base64CodecConstants.Base64LineSize];
        public TextWriter Writer { get; set; }

        public byte[] LeftOverBytes { get; set; }
        public int LeftOverBytesCount { get; set; }

        
    }
}
