using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class Int64Api
    {
        public void Write(Block_I block, long valueToWrite)
        {
            var iOffset = block.Position + 8;

            block.Position = iOffset;

            block.Data[--iOffset] = (byte)(valueToWrite >> 56);
            block.Data[--iOffset] = (byte)(valueToWrite >> 48);
            block.Data[--iOffset] = (byte)(valueToWrite >> 40);
            block.Data[--iOffset] = (byte)(valueToWrite >> 32);
            block.Data[--iOffset] = (byte)(valueToWrite >> 24);
            block.Data[--iOffset] = (byte)(valueToWrite >> 16);
            block.Data[--iOffset] = (byte)(valueToWrite >> 8);
            block.Data[--iOffset] = (byte)(valueToWrite >> 0);
        }

        public void Read(Block_I block, out long valueToRead)
        {
            var iOffset = (block.Position += 8) - 1;

            valueToRead = (block.Data[iOffset] << 56)
                | (block.Data[--iOffset] << 48) 
                | (block.Data[--iOffset] << 40) 
                | (block.Data[--iOffset] << 32) 
                | (block.Data[--iOffset] << 24) 
                | (block.Data[--iOffset] << 16)
                | (block.Data[--iOffset] << 8) 
                | (block.Data[--iOffset]);
        }
    }
}
