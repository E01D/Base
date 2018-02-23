namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    /// <summary>
    /// Represents a segment of text.
    /// </summary>
    public abstract class TextSegment:TextSegment_I
    {
        /// <summary>
        /// Gets or sets the cached value of the segment to speed up fetching the value, given caching is turned on.
        /// </summary>
        public abstract string CachedValue { get; set; }

        

        /// <summary>
        /// Gets the column on which the segment ended.  This greatly aides in debugging.
        /// </summary>
        public long EndColumn { get; set; }

        /// <summary>
        /// Gets the line on which the segment ended.    This greatly aides in debugging.
        /// </summary>
        public long EndLine { get; set; }

        /// <summary>
        /// Gets or sets the end position of the segment.  
        /// </summary>
        public long EndPosition { get; set; }

        

        /// <summary>
        /// Gets or sets the source of the value for this text segment.
        /// </summary>
        public TextSource_I Source { get; set; }

        /// <summary>
        /// Gets or sets the cached value of the segment to speed up fetching the value, given caching is turned on.
        /// </summary>
        public abstract bool SupportsCachedValue { get; }

       

        /// <summary>
        /// Gets the column on which the segment starts.  This greatly aides in debugging.
        /// </summary>
        public long StartColumn { get; set; }

        /// <summary>
        /// Gets or sets the line on which the segment starts.   This greatly aides in debugging.
        /// </summary>
        public long StartLine { get; set; }

        /// <summary>
        /// Gets or sets the start position of the segment
        /// </summary>
        public long StartPosition { get; set; }

        

        
        
    }
}
