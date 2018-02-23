using System;
using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class CharApi : Codec_I<char>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (char)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (char)value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Read(Block_I block)
        {
            var bytes = block.Data;
            var offset = block.Position;

            var lower = bytes[offset];                 // Little Endian - smaller address, least significant byte, which should be generally be the ascii characters
            var upper = bytes[offset + 1];             // Little Endian - larger address, most significant byte, which should generally be 00 for ascii characters

            return (char)((lower & 0xff) | ((upper & 0xff) << 8));

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, char value)
        {
            var bytes = block.Data;
            var offset = block.Position;

            Write(bytes, offset, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Read(byte[] bytes, int offset)
        {
            var upper = bytes[offset + 1];          // Little Endian - larger address, most significant byte, which should generally be 00 for ascii characters         
            var lower = bytes[offset];              // Little Endian - smaller address, least significant byte, which should be generally be the ascii characters

            return (char)((lower & 0xff) | ((upper & 0xff) << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] bytes, int offset, char value)
        {

            bytes[offset] = (byte)(value & 0xff);   // Little Endian - smaller address, least significant byte, which should be generally be the ascii characters
            bytes[offset+1] = (byte)(value >> 8);         // Little Endian - larger address, most significant byte, which should generally be 00 for ascii characters
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char[] ReadAscii(Block_I block, int length)
        {
            return ReadAscii(block.Data, block.Position, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char ReadAscii(Block_I block)
        {
            return ReadAscii(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char ReadAscii(byte[] bytes, int offset)
        {
            return (char)bytes[offset];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char[] ReadAscii(byte[] bytes, int offset, int length)
        {
            var ascii = new char[length];

            for (var i = 0; i < length; i++)
            {
                 ascii[i] = (char)bytes[offset + i];
            }

            return ascii;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char Read(BlockStream_I stream)
        {
            var result = Read(stream.Block);

            stream.Block.Position += 2;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char ReadAscii(BlockStream_I blockStream)
        {
            var result = ReadAscii(blockStream.Block);

            blockStream.Block.Position++;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public char[] ReadAscii(BlockStream_I blockStream, int length)
        {
            var result = ReadAscii(blockStream.Block, length);

            blockStream.Block.Position += length;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteAscii(Block_I block, char value)
        {
            WriteAscii(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteAscii(byte[] bytes, int offset, char value)
        {
            bytes[offset] = (byte) (value & 0xff);
        }
    }
}
