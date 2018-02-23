using Root.Coding.Code.Enums.E01D.Base.Textual;

namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    public class TextSourceFile:TextSourceBase
    {
        public override TextSourceType Type => TextSourceType.File;
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
