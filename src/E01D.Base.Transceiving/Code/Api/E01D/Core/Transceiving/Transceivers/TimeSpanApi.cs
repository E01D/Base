using System;
using Root.Code.Exts.E01D.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class TimeSpanApi
    {
        public void Write(Block_I block, TimeSpan data)
        {
            block.Write(data.Ticks);
        }

        public void Read(Block_I block, out TimeSpan data)
        {
            long ticks;

            block.Read(out ticks);

            data = new TimeSpan(ticks);
        }
    }
}
