using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.BigEndian
{
    public class UInt32Api:Codec_I<uint>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (uint)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (uint)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Read(byte[] bytes, int offset)
        {
            offset += 3;

            // It is generally faster to substract one each time then to add a fixed value each time as the operation does not require an argument to be passed.
            // In big endian, you store the most significant byte in the smallest address.
            var lower0 = bytes[offset--];  // least significant byte, largest address
            var mid1 = bytes[offset--];
            var mid2 = bytes[offset--];
            var upper3 = bytes[offset];      // most significant byte, smallest address

            return (uint)((upper3 << 24) + (mid2 << 16) + (mid1 << 8) + lower0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, uint value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, uint value)
        {
            offset += 3;

            // It is generally faster to substract one each time then to add a fixed value each time as the operation does not require an argument to be passed.
            // In big endian, you store the most significant byte in the smallest address.

            bytes[offset--] = (byte)(value);       // least significant byte, largest address
            bytes[offset--] = (byte)(value >> 8);
            bytes[offset--] = (byte)(value >> 16);
            bytes[offset] = (byte)(value >> 24);      // most significant byte, smallest address
        }
    }
}
