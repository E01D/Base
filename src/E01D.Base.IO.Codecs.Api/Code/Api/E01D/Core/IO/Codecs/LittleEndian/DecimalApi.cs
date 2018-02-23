using System;
using System.Runtime.CompilerServices;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class DecimalApi : Codec_I<decimal>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (decimal)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (decimal)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public decimal Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public decimal Read(byte[] bytes, int offset)
        {
            var values = new int[4];

            for (var i = 0; i < values.Length; i++)
            {
                values[i] = XCodecs.Api.LittleEndian.ReadInt32(bytes, offset + i * 4);
            }

            return new decimal(values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, decimal value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, decimal value)
        {
            var values = System.Decimal.GetBits(value);

            for (var i = 0; i < values.Length; i++)
            {
                XCodecs.Api.LittleEndian.WriteInt32(bytes, offset + i * 4, values[i]);
            }
        }
    }
}
