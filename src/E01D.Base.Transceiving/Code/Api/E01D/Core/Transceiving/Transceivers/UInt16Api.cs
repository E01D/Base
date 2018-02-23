using Root.Code.Exts.E01D.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class UInt16Api
    {
        public void Write(Block_I block, ushort data)
        {
            block.Write((short)data);
        }

        public void Read(Block_I block, out ushort data)
        {
            short dataLong;

            block.Read(out dataLong);

            data = (ushort)dataLong;
        }
    }
}
