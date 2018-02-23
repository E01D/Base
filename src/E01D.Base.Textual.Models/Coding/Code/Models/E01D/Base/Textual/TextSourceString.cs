using Root.Coding.Code.Enums.E01D.Base.Textual;

namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    public class TextSourceString:TextSourceBase
    {
        public string Content { get; set; }

        public override TextSourceType Type => TextSourceType.String;

        //public bool Current(out char lexChar)
        //{
        //    return XTextual.TextSources.Strings.GetCurrent(this, out lexChar);
        //}

        //public bool LookAhead(out char lexChar)
        //{
        //    return XTextual.TextSources.Strings.GetLookAhead(this, out lexChar);
        //}
    }
}
