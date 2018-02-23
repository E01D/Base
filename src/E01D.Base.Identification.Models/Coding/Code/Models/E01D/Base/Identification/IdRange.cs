namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public class IdRange:IdRange_I
    {
        /// <summary>
        /// Gets or sets the first id number in the sequence.
        /// </summary>
        public long StartInclusive { get; set; }

        /// <summary>
        /// Gest or sets the last id number in the sequence.
        /// </summary>
        public long EndInclusive { get; set; }
    }
}
