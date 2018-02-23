using Root.Coding.Code.Enums.E01D.Base.Textual;

namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    public class TextSourceStream : TextSourceBase
    {
        public override TextSourceType Type => TextSourceType.Stream;
        //public override bool Current(out char lexChar)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public override bool LookAhead(out char lexChar)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
