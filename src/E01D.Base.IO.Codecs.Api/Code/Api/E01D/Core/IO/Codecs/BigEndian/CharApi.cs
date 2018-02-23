using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.BigEndian
{
    public class CharApi:Codec_I<char>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (char)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (char)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Read(Block_I block)
        {
            var bytes = block.Data;
            var offset = block.Position;

            var upper = bytes[offset];     // Big Endian - smaller address, most significant byte, which should be generally 00
            var lower = bytes[offset + 1]; // larger address, least significant byte, which should generally be the ascii number

            return (char)((lower & 0xff) | ((upper & 0xff) << 8));
            
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, char value)
        {
            var bytes = block.Data;
            var offset = block.Position;

            bytes[offset + 1] = (byte)(value & 0xff);  // Big Endian - larger address, least significant byte, which should generally be the ascii number
            bytes[offset] = (byte)(value >> 8); // Big Endian - smaller address, most significant byte, which should be generally 00
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Read(byte[] bytes, int offset)
        {
            var upper = bytes[offset];     // Big Endian - smaller address, most significant byte, which should be generally 00
            var lower = bytes[offset + 1]; // Big Endian - larger address, least significant byte, which should generally be the ascii number

            return (char)((lower & 0xff) | ((upper & 0xff) << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, char value)
        {

            bytes[offset+1] = (byte)(value & 0xff);  // Big Endian - larger address, least significant byte, which should generally be the ascii number
            bytes[offset] = (byte)(value >> 8); // Big Endian - smaller address, most significant byte, which should be generally 00
        }
    }
}
