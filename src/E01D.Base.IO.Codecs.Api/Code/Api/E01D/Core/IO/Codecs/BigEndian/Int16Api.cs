using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.BigEndian
{
    public class Int16Api:Codec_I<short>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (short)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (short)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Read(byte[] bytes, int offset)
        {
            // In big endian, you store the most significant byte in the smallest address.
            var lower = bytes[offset + 1];  // least significant byte, largest address
            var upper = bytes[offset];      // least significant byte, smallest address

            return (short)((upper << 8) + lower);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, short value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, short value)
        {
            // In big endian, you store the most significant byte in the smallest address.
            bytes[offset] = (byte)(value >> 8); // most significant byte, smallest address
            bytes[offset + 1] = (byte)(value);  // least significant byte, largest address
        }
    }
}
