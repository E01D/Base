
using Root.Coding.Code.Enums.E01D.Base.Textual;

namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    public abstract class TextSourceBase : TextSource_I
    {
        public abstract TextSourceType Type
        {
            get;
        }

        //public abstract bool Current(out char lexChar);

        //public abstract bool LookAhead(out char lexChar);
    

        public long Position { get; set; }
        public long Line { get; set; }
        public long Column { get; set; }

        public TextSourceContext Context { get; set; }
    }
}
