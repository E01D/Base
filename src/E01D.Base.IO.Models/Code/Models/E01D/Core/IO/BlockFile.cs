using System.Collections.Generic;

namespace Root.Code.Models.E01D.Core.IO
{
    public class BlockFile:BlockFile_I
    {
        /// <summary>
        /// Gets or sets the position within the file
        /// </summary>
        public long Position { get; set; }

        /// <summary>
        /// Gets or sets the blocks that make up the file
        /// </summary>
        public List<Block_I> Blocks { get; set; } = new List<Block_I>();

        public Block_I CurrentBlock { get; set; }

        public long Length { get; set; }
    }
}
