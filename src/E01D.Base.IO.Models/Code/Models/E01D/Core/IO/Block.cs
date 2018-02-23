namespace Root.Code.Models.E01D.Core.IO
{
    public class Block: Block_I
    {
        /// <summary>
        /// Gets or sets the current cursor position within the block
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the offset of the block from the total stream.
        /// </summary>
        public long Address { get; set; }

        public int Length { get; set; }

        public byte[] Data { get; set; }

        public Block_I Next { get; set; }
    }
}
