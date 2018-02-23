using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class Int32Api
    {
        public void Write(Block_I block, int data)
        {
            var iOffset = block.Position + 4;

            block.Position = iOffset;

            block.Data[--iOffset] = (byte)data;
            block.Data[--iOffset] = (byte)(data >>= 8);
            block.Data[--iOffset] = (byte)(data >>= 8);
            block.Data[--iOffset] = (byte)(data >> 8);
        }

        public void Read(Block_I block, out int data)
        {
            var iOffset = (block.Position += 4) - 1;

            data = (block.Data[iOffset]) | (block.Data[--iOffset]) << 8 | (block.Data[--iOffset]) << 16 | block.Data[--iOffset] << 24;
        }
    }
}
