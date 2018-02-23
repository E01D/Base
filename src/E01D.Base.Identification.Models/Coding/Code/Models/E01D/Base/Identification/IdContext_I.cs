namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public interface IdContext_I
    {
        AvailableIdRange_I AvailableRange { get; set; }

        int DefaultIdRangeSize { get; set; } 

        object SyncRoot { get; set; }
    }
}
