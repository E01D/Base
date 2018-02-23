using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class Int08Api:Codec_I<sbyte>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (sbyte)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (sbyte)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Read(Block_I block)
        {
            var bytes = block.Data;
            var offset = block.Position;

            return (sbyte)bytes[offset];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, sbyte value)
        {
            var bytes = block.Data;
            var offset = block.Position;

            bytes[offset] = (byte)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Read(byte[] bytes, int offset = 0)
        {
            return (sbyte)bytes[offset];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, sbyte value)
        {
            bytes[offset] = (byte)value;
        }
    }
}
