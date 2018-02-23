using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class Int16Api
    {
        public void Write(Block_I block, short data)
        {
            var iOffset = block.Position + 2;

            block.Position = iOffset;

            block.Data[--iOffset] = (byte)(data & 0xff);
            block.Data[--iOffset] = (byte)(data >> 8);
        }

        public void Read(Block_I block, out short data)
        {
            var iOffset = (block.Position += 2) - 1;

            data = (short)((block.Data[iOffset]) | (block.Data[--iOffset]) << 8);
        }
    }
}
