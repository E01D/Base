namespace Root.Coding.Code.Models.E01D.Base.Textual
{
    /// <summary>
    /// Represents a segment of text.
    /// </summary>
    public interface TextSegment_I
    {
        /// <summary>
        /// Gets the cached value of the segment to speed up fetching the value, given caching is turned on.
        /// </summary>
        string CachedValue { get; set; }

        ///// <summary>
        ///// Gets the end position of the segment
        ///// </summary>
        //long EndCaretPosition { get; }

        /// <summary>
        /// Gets the column on which the segment ended.  This greatly aides in debugging.
        /// </summary>
        long EndColumn { get; }

        /// <summary>
        /// Gets the line on which the segment ended.    This greatly aides in debugging.
        /// </summary>
        long EndLine { get; }

        /// <summary>
        /// Gets the end position of the segment.  
        /// </summary>
        long EndPosition { get; }

        ///// <summary>
        ///// Gets the value of the text segment.
        ///// </summary>
        ///// <returns>The actual string value of the text segment from the source.</returns>
        //string GetValue();

        ///// <summary>
        ///// Gets the length of the segment
        ///// </summary>
        //long Length { get; }

        

        ///// <summary>
        ///// Gets or sets the start position of the segment
        ///// </summary>
        //long StartCaretPosition { get; }

        /// <summary>
        /// Gets the column on which the segment starts.  This greatly aides in debugging.
        /// </summary>
        long StartColumn { get; }

        /// <summary>
        /// Gets or sets the line on which the segment starts.   This greatly aides in debugging.
        /// </summary>
        long StartLine { get; }

        /// <summary>
        /// Gets or sets the start position of the segment
        /// </summary>
        long StartPosition { get;  }

        /// <summary>
        /// Gets or sets the source of the value for this text segment.
        /// </summary>
        TextSource_I Source { get; }

        /// <summary>
        /// Gets or sets the cached value of the segment to speed up fetching the value, given caching is turned on.
        /// </summary>
        bool SupportsCachedValue { get;  }
        
    }
}
