using System.IO;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Models.E01D.Json.Codecs
{
    public class JsonReadTextContext: JsonReadContext
    {
        public char[] Chars { get; set; }
        public int CharsUsed { get; set; }
        public int CharPos { get; set; }

        public bool IsEndOfFile { get; set; }

        public int LineNumber { get; set; }

        public int LineStartPos { get; set; }

        public TextReader Reader { get; set; }

        //public PropertyNameTable NameTable { get; set; }

        public bool SafeAsync { get; set; }
        
        public StringBuffer StringBuffer { get; set; }
        
        public StringReference StringReference { get; set; }
        




    }
}
