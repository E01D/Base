using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class CharApi
    {
        public void Write(Block_I block, char data)
        {
            var iOffset = block.Position + 2;

            block.Position = iOffset;

            block.Data[--iOffset] = (byte)(data & 0xff);
            block.Data[--iOffset] = (byte)(data >> 8);
        }

        public void Read(Block_I block, out char data)
        {
            var byte1 = block.Data[block.Position++];
            var byte2 = block.Data[block.Position++];

            data = (char)((byte1 & 0xff) | ((byte2 & 0xff) << 8));
        }
    }
}
