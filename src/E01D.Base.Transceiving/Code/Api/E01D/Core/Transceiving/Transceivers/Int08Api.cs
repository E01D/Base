using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class Int08Api
    {
        public void Write(Block_I block, sbyte data)
        {
            block.Data[block.Position++] = (byte)data;
        }

        public void Read(Block_I block, out sbyte data)
        {
            data = (sbyte)block.Data[block.Position++];
        }

  
    }
}
