using System;
using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class UInt16Api:Codec_I<ushort>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (ushort)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (ushort)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Read(byte[] bytes, int offset)
        {
            // In little endian, you store the least significant byte in the smallest address. 
            var upper = bytes[offset + 1];  // most significant byte, largest address
            var lower = bytes[offset];      // least significant byte, smallest address

            return (ushort)(lower + (upper << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, ushort value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, ushort value)
        {
            // In little endian, you store the least significant byte in the smallest address. 
            bytes[offset] = (byte)(value);          // least significant byte, smallest address
            bytes[offset + 1] = (byte)(value >> 8); // most significant byte, largest address
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Read(BlockStream_I blockStream)
        {
            var result = Read(blockStream.Block);

            blockStream.Block.Position += 2;

            return result;
        }
    }
}
