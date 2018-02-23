using Root.Code.Exts.E01D.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class UInt32Api
    {
        public void Write(Block_I block, uint data)
        {
            block.Write((int)data);
        }

        public void Read(Block_I block, out uint data)
        {
            int dataLong;

            block.Read(out dataLong);

            data = (uint)dataLong;
        }
    }
}
