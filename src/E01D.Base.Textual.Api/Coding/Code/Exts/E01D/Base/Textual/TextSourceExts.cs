using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Textual;

namespace Root.Coding.Code.Exts.E01D.Base.Textual
{
    public static class TextSourceExts
    {
        public static bool LookAhead(this TextSource_I source, out char lexChar)
        {
            switch(source.Type)
            {
                case Root.Coding.Code.Enums.E01D.Base.Textual.TextSourceType.File:
                    {
                        throw new System.NotImplementedException();
                    }
                case Root.Coding.Code.Enums.E01D.Base.Textual.TextSourceType.Stream:
                    {
                        throw new System.NotImplementedException();
                    }
                case Root.Coding.Code.Enums.E01D.Base.Textual.TextSourceType.String:
                    {
                        return XTextual.TextSources.Strings.GetLookAhead((TextSourceString)source, out lexChar);
                    }
                default:
                    {
                        throw new System.NotSupportedException();
                    }
            }
            
        }

        public static bool Current(this TextSource_I source, out char lexChar)
        {
            switch (source.Type)
            {
                case Root.Coding.Code.Enums.E01D.Base.Textual.TextSourceType.File:
                    {
                        throw new System.NotImplementedException();
                    }
                case Root.Coding.Code.Enums.E01D.Base.Textual.TextSourceType.Stream:
                    {
                        throw new System.NotImplementedException();
                    }
                case Root.Coding.Code.Enums.E01D.Base.Textual.TextSourceType.String:
                    {
                        return XTextual.TextSources.Strings.GetCurrent((TextSourceString)source, out lexChar);
                    }
                default:
                    {
                        throw new System.NotSupportedException();
                    }
            }

        }
    }
}
