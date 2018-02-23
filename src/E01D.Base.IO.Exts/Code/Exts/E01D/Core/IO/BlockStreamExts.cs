using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Exts.E01D.Core.IO
{
    public static class BlockStreamExts
    {
        public static void Buffer(this BlockStream_I blockStream, int length)
        {
            XIO.Api.BlockStreams.Buffer(blockStream, length);
        }

        public static void Buffer(this BlockStream_I blockStream, long position, int length)
        {
            XIO.Api.BlockStreams.Buffer(blockStream, position, length);
        }

       
    }
}
