using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Textual;

namespace Root.Coding.Code.Exts.E01D.Base.Textual
{
    public static class TextSegmentExts
    {
        /// <summary>
        /// Gets or sets the end position of the segment
        /// </summary>
        public static long EndCaretPosition(this TextSegment_I segment)
        {
            return XTextual.TextSegments.GetEndCaretPosition(segment);
        }

        /// <summary>
        /// Gets the value of the text segment.
        /// </summary>
        /// <returns>The actual string value of the text segment from the source.</returns>
        public static string GetValue(this TextSegment_I segment)
        {
            return XTextual.TextSegments.GetValue(segment);
        }

        /// <summary>
        /// Gets the length of the segment
        /// </summary>
        public static long Length(this TextSegment_I segment)
        {
            return XTextual.TextSegments.GetLength(segment);
        }

        /// <summary>
        /// Gets or sets the start position of the segment
        /// </summary>
        public static long StartCaretPosition(this TextSegment_I segment)
        {
            return XTextual.TextSegments.GetStartCaretPosition(segment);
        }
    }
}
