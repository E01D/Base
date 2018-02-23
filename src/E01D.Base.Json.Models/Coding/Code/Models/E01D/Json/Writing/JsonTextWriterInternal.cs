using System.IO;
using Root.Coding.Code.Api.E01D.Memory;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings.Base64Encoding;

namespace Root.Coding.Code.Models.E01D.Json.Writing
{
    public class JsonTextWriterInternal: JsonWriterInternal
    {
        public TextWriter Writer { get; set; }
        public Base64Encoder Base64Encoder { get; set; }
        public char IndentChar { get; set; }
        public int Indentation { get; set; }
        public char QuoteChar { get; set; }
        public bool QuoteName { get; set; }
        public bool[] CharEscapeFlags { get; set; }
        public char[] WriteBuffer { get; set; }
        public ArrayPoolApi_I<char> ArrayPool { get; set; }
        public char[] IndentChars { get; set; }

        
    }
}
