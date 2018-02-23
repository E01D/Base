using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Textual;

namespace Root.Coding.Code.Exts.E01D.Base.Textual
{
    public static class TextSourceStringExts
    {
        public static bool Current(this TextSourceString source, out char lexChar)
        {
            return XTextual.TextSources.Strings.GetCurrent(source, out lexChar);
        }

        public static bool LookAhead(this TextSourceString source, out char lexChar)
        {
            return XTextual.TextSources.Strings.GetLookAhead(source, out lexChar);
        }
    }
}
