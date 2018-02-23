using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Textual;

namespace Root.Coding.Code.Api.E01D.Base.Textual
{
    public class TextSegmentApi
    {
        public long GetLength(TextSegment_I textSegment)
        {
            if (textSegment == null) return 0;

            return textSegment.EndPosition - textSegment.StartPosition + 1;
        }

        public long GetEndCaretPosition(TextSegment_I textSegment)
        {
            if (textSegment == null) return -1;

            return textSegment.EndPosition + 1;
        }

        public long GetStartCaretPosition(TextSegment_I textSegment)
        {
            if (textSegment == null) return -1;

            return textSegment.StartPosition;
        }

        public string GetValue(TextSegment_I textSegment)
        {
            return XTextual.TextSources.GetValue(textSegment);
        }
    }
}
