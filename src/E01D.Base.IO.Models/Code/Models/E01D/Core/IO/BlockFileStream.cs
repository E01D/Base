namespace Root.Code.Models.E01D.Core.IO
{
    public class BlockFileStream:BlockStream
    {
        

        public long NextAddressToIssue { get; set; }

        public BlockNode FreeBlockTree { get; set; }
    }
}
