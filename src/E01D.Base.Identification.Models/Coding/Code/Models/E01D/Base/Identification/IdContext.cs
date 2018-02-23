namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public class IdContext: IdContext_I
    {
        public AvailableIdRange_I AvailableRange { get; set; } = new AvailableIdRange()
        {
            LastIssuedId = 0
        };

        public int DefaultIdRangeSize { get; set; } = 1000;

        public object SyncRoot { get; set; } = new object();
    }
}
