using System;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;
using Root.Code.Models.E01D.Core.IO.Codecs.Streams;

namespace Root.Code.Api.E01D.Core.IO.Codecs.Streams
{
    public class BlockStreamApi
    {
        public bool ReadBool(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadBool(block);

            block.Position++;

            return value;
        }

        public char ReadChar(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadChar(block);

            block.Position+=2;

            return value;
        }

        public byte[] ReadBytes(BlockStream_I blockstream, int length)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadBytes(block, length);

            block.Position++;

            return value;
        }
        public float ReadSingle(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadSingle(block);

            block.Position++;

            return value;
        }

        public double ReadDouble(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadDouble(block);

            block.Position+=8;

            return value;
        }

        public decimal ReadDecimal(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadDecimal(block);

            block.Position += 16;

            return value;
        }

        public string ReadString(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadString(block);

            block.Position += 4 + ((value?.Length ?? 0) * 2);

            return value;
        }

        public DateTime ReadDateTime(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadDateTime(block);

            block.Position += 8;

            return value;
        }

        public TimeSpan ReadTimeSpan(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadTimeSpan(block);

            block.Position += 8;

            return value;
        }

        public byte ReadUInt08(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadUInt08(block);

            block.Position++;

            return value;
        }

        public ushort ReadUInt16(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadUInt16(block);

            block.Position+=2;

            return value;
        }

        public uint ReadUInt32(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadUInt32(block);

            block.Position += 4;

            return value;
        }

        public ulong ReadUInt64(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadUInt64(block);

            block.Position += 8;

            return value;
        }

        public sbyte ReadInt08(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadInt08(block);

            block.Position++;

            return value;
        }

        public short ReadInt16(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadInt16(block);

            block.Position+=2;

            return value;
        }

        public int ReadInt32(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadInt32(block);

            block.Position+=4;

            return value;
        }

        public long ReadInt64(BlockStream_I blockstream)
        {
            var block = blockstream.Block;

            var value = XCodecs.ReadInt64(block);

            block.Position+= 8;

            return value;
        }

        public void WriteBool(BlockStream_I blockstream, bool value)
        {
            var block = blockstream.Block;

            XCodecs.WriteBool(block, value);

            block.Position++;

        }

        public void WriteChar(BlockStream_I blockstream, char value)
        {
            var block = blockstream.Block;

            XCodecs.WriteChar(block, value);

            block.Position+=2;
        }

        public void WriteBytes(BlockStream_I blockstream, byte[] value)
        {
            var block = blockstream.Block;

            XCodecs.WriteBytes(block, value);

            block.Position += value.Length;
        }

        public void WriteSingle(BlockStream_I blockstream, float value)
        {
            var block = blockstream.Block;

            XCodecs.WriteSingle(block, value);

            block.Position += 4;
        }

        public void WriteDouble(BlockStream_I blockstream, double value)
        {
            var block = blockstream.Block;

            XCodecs.WriteDouble(block, value);

            block.Position += 8;
        }

        public void WriteDecimal(BlockStream_I blockstream, decimal value)
        {
            var block = blockstream.Block;

            XCodecs.WriteDecimal(block, value);

            block.Position += 16;
        }

        public void WriteString(BlockStream_I blockstream, string value)
        {
            var block = blockstream.Block;

            XCodecs.WriteString(block, value);

            block.Position += 4 + ((value?.Length ?? 0) * 2);
        }

        public void WriteDateTime(BlockStream_I blockstream, DateTime value)
        {
            var block = blockstream.Block;

            XCodecs.WriteDateTime(block, value);

            block.Position += 8;
        }

        public void WriteTimeSpan(BlockStream_I blockstream, TimeSpan value)
        {
            var block = blockstream.Block;

            XCodecs.WriteTimeSpan(block, value);

            block.Position += 8;
        }

        public void WriteUInt08(BlockStream_I blockstream, byte value)
        {
            var block = blockstream.Block;

            XCodecs.WriteUInt08(block, value);

            block.Position += 1;
        }

        public void WriteUInt16(BlockStream_I blockstream, ushort value)
        {
            var block = blockstream.Block;

            XCodecs.WriteUInt16(block, value);

            block.Position += 2;
        }

        public void WriteUInt32(BlockStream_I blockstream, uint value)
        {
            var block = blockstream.Block;

            XCodecs.WriteUInt32(block, value);

            block.Position += 4;
        }

        public void WriteUInt64(BlockStream_I blockstream, ulong value)
        {
            var block = blockstream.Block;

            XCodecs.WriteUInt64(block, value);

            block.Position += 8;
        }

        public void WriteInt08(BlockStream_I blockstream, sbyte value)
        {
            var block = blockstream.Block;

            XCodecs.WriteInt08(block, value);

            block.Position += 1;
        }

        public void WriteInt16(BlockStream_I blockstream, short value)
        {
            var block = blockstream.Block;

            XCodecs.WriteInt16(block, value);

            block.Position += 2;
        }

        public void WriteInt32(BlockStream_I blockstream, int value)
        {
            var block = blockstream.Block;

            XCodecs.WriteInt32(block, value);

            block.Position += 4;
        }

        public void WriteInt64(BlockStream_I blockstream, long value)
        {
            var block = blockstream.Block;

            XCodecs.WriteInt64(block, value);

            block.Position += 8;
        }
    }
}
