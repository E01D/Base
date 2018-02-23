using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Exts.E01D.Core.IO
{
    public static class BlockExts
    {
        public static sbyte ReadInt8(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadInt08(block);
        }

        public static short ReadInt16(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadInt16(block);
        }

        public static int ReadInt32(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadInt32(block);
        }

        public static long ReadInt64(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadInt64(block);
        }

        public static byte ReadUInt8(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadUInt08(block);
        }

        public static ushort ReadUInt16(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadUInt16(block);
        }

        public static ushort ReadUInt16(this Block_I block, int position)
        {
            return XCodecs.Api.LittleEndian.ReadUInt16(block, position);
        }

        public static uint ReadUInt32(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadUInt32(block);
        }

        public static ulong ReadUInt64(this Block_I block)
        {
            return XCodecs.Api.LittleEndian.ReadUInt64(block);
        }

        public static char[] ReadAsciiChars(this Block_I block, int length)
        {
            return XCodecs.Api.LittleEndian.ReadAsciiChars(block, length);
        }
    }
}
