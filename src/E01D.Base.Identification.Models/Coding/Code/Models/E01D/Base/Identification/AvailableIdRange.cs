namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public class AvailableIdRange: IdRange, AvailableIdRange_I
    {
        public long LastIssuedId { get; set; }
    }
}
