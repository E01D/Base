using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.BigEndian
{
    public class BoolApi:Codec_I<bool>
    {
        private const byte TRUE = 0x1;
        private const byte FALSE = 0x0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (bool) value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (bool)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Read(Block_I block)
        {
            var bytes = block.Data;
            var offset = block.Position;

            return bytes[offset] > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, bool value)
        {
            var bytes = block.Data;
            var offset = block.Position;

            bytes[offset] = value ? TRUE : FALSE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Read(byte[] bytes, int offset = 0)
        {
            return bytes[offset] > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, bool value)
        {
            bytes[offset] = value ? TRUE : FALSE;
        }
    }
}
