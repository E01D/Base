using Root.Coding.Code.Enums.E01D.Base.Textual;

namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    public interface TextSource_I
    {
        TextSourceType Type { get; }

        //bool Current(out char lexChar);

        //bool LookAhead(out char lexChar);

        long Position { get; set; }
    }
}
