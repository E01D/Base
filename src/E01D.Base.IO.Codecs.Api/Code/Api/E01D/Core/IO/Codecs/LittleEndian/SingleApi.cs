using System;
using System.Runtime.CompilerServices;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class SingleApi:Codec_I<float>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (float)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (float)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float Read(byte[] bytes, int offset)
        {
            return BitConverter.ToSingle(XCodecs.Api.LittleEndian.UInt08.Read(bytes, offset, 4), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, float value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, float value)
        {
            var floatValue = BitConverter.GetBytes(value);

            XCodecs.Api.LittleEndian.UInt08.Write(bytes, offset, floatValue);
        }
    }
}
