using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Exts.E01D.Core.IO
{
    public static class BlockStreamExts
    {
        public static char ReadAsciiChar(this BlockStream_I blockStream)
        {
            return XCodecs.Api.LittleEndian.ReadAsciiChar(blockStream);
        }

        public static char[] ReadAsciiChars(this BlockStream_I blockStream, int length)
        {
            return XCodecs.Api.LittleEndian.ReadAsciiChars(blockStream, length);
        }

        public static uint ReadUInt16(this BlockStream_I blockStream)
        {
            return XCodecs.Api.LittleEndian.ReadUInt16(blockStream);
        }

        public static uint ReadUInt32(this BlockStream_I blockStream)
        {
            return XCodecs.Api.LittleEndian.ReadUInt32(blockStream);
        }

        public static ulong ReadUInt64(this BlockStream_I blockStream)
        {
            return XCodecs.Api.LittleEndian.ReadUInt64(blockStream);
        }
    }
}
