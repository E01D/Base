
namespace Root.Code.Models.E01D.Core.IO
{
    public class BlockStream: BlockStream_I
    {
        public System.IO.Stream Stream { get; set; }

        public Block_I Block { get; set; }
    }
}
