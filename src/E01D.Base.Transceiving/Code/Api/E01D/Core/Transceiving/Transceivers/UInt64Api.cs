using Root.Code.Exts.E01D.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class UInt64Api
    {
        public void Write(Block_I block, ulong data)
        {
            block.Write((long) data);
        }

        public void Read(Block_I block, out ulong data)
        {
            long dataLong;

            block.Read(out dataLong);

            data = (ulong)dataLong;
        }
    }
}
