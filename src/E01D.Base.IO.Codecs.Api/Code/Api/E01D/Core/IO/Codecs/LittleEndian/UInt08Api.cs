using System;
using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class UInt08Api:Codec_I<byte>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (byte)value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (byte)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Read(Block_I block, int length)
        {
            return Read(block.Data, block.Position, length);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Read(byte[] bytes, int offset)
        {
            return bytes[offset];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Read(byte[] bytes, int offset, int length)
        {
            var result = new byte[length];

            Buffer.BlockCopy(bytes, offset, result, 0, length);

            return result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, byte value)
        {
            Write(block.Data, block.Position, value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, byte value)
        {
            bytes[offset] = value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, byte[] value)
        {
            var j = 0;

            for (var i = offset; i < offset + value.Length; i++)
            {
                Write(bytes, i, value[j]);
                
                j++;
            }
        }
    }
}
