namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public interface AvailableIdRange_I:IdRange_I
    {
        long LastIssuedId { get; set; }
    }
}
