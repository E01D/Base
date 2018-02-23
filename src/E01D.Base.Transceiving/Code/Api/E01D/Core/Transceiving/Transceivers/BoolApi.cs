using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class BoolApi
    {
        public void Write(Block_I block, bool data)
        {
            block.Data[block.Position++] = (byte)(data ? 0x1 : 0x0);
        }

        public void Read(Block_I block, out bool data)
        {
            var byteData = block.Data[block.Position++];

            data = byteData != 0x0;
        }
    }
}
