using System;
using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class UInt32Api:Codec_I<uint>
    {
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (uint)value);
        }

        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (uint)value);
        }

        public uint Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        public uint Read(byte[] bytes, int offset)
        {
            offset += 3;

            // It is generally faster to substract one each time then to add a fixed value each time as the operation does not require an argument to be passed.
            // In little endian, you store the least significant byte in the smallest address. 
            var upper3 = bytes[offset--];  // most significant byte, largest address
            var mid2 = bytes[offset--];
            var mid1 = bytes[offset--];
            var lower0 = bytes[offset];      // least significant byte, smallest address

            return (uint)((upper3 << 24) + (mid2 << 16) + (mid1 << 8) + lower0);
        }

        public void Write(Block_I block, uint value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, uint value)
        {
            offset += 3;

            // It is generally faster to substract one each time then to add a fixed value each time as the operation does not require an argument to be passed.
            // In little endian, you store the least significant byte in the smallest address. 
            bytes[offset--] = (byte)(value >> 24);  // most significant byte, largest address
            bytes[offset--] = (byte)(value >> 16);
            bytes[offset--] = (byte)(value >> 8);
            bytes[offset] = (byte)value;      // least significant byte, smallest address
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Read(BlockStream_I blockStream)
        {
            var result = Read(blockStream.Block);

            blockStream.Block.Position += 4;

            return result;
        }
    }
}
