using System;
using System.Runtime.CompilerServices;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class TimeSpanApi:Codec_I<TimeSpan>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (TimeSpan)value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (TimeSpan)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TimeSpan Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TimeSpan Read(byte[] bytes, int offset)
        {
            return new TimeSpan(XCodecs.Api.LittleEndian.ReadInt64(bytes, offset));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, TimeSpan value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, TimeSpan value)
        {
            XCodecs.Api.LittleEndian.WriteInt64(bytes, offset, value.Ticks);
        }
    }
}
