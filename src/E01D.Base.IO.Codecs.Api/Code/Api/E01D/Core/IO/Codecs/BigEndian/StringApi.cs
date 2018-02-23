using System.Runtime.CompilerServices;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.BigEndian
{
    public class StringApi:Codec_I<string>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (string)value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (string)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Read(byte[] bytes, int offset)
        {
            return ReadUTF16String(bytes, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, string value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, string value)
        {
            WriteUTF16String(bytes, offset, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteUTF16String(byte[] bytes, int offset, string value)
        {
            if (value == null)
            {
                XCodecs.Api.BigEndian.WriteInt32(bytes, offset, -1);
            }
            else
            {
                XCodecs.Api.BigEndian.WriteInt32(bytes, offset, value.Length);

                for (var i = 0; i < value.Length; i++)
                {
                    XCodecs.Api.BigEndian.WriteChar(bytes, 4 + (2 * i), value[i]);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ReadUTF16String(byte[] bytes, int offset)
        {
            var length = XCodecs.Api.BigEndian.ReadInt32(bytes, offset);

            if (length < 0) return null;

            var x = new char[length];

            for (var i = 0; i < length; i++)
            {
                x[i] = XCodecs.Api.BigEndian.ReadChar(bytes, 4 + (2 * i));
            }

            return new string(x);
        }
    }
}
