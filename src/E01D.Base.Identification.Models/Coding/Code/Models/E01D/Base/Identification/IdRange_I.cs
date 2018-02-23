namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public interface IdRange_I
    {
        /// <summary>
        /// Gets or sets the first id number in the sequence.
        /// </summary>
        long StartInclusive { get; set; }

        /// <summary>
        /// Gest or sets the last id number in the sequence.
        /// </summary>
        long EndInclusive { get; set; }
    }
}
