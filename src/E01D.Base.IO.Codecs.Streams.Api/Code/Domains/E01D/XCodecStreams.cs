using System;

using Root.Code.Api.E01D.Core.IO.Codecs;
using Root.Code.Models.E01D.Core.IO;
using Root.Code.Models.E01D.Core.IO.Codecs.Streams;

namespace Root.Code.Domains.E01D
{
    public static class XCodecStreams
    {
        public static StreamApi Api { get; set; } = new StreamApi();

        public static bool ReadBool(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadBool(blockstream);
        }

        public static char ReadChar(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadChar(blockstream);
        }

        public static byte[] ReadBytes(BlockStream_I blockstream, int length)
        {
            return Api.BlockStreams.ReadBytes(blockstream, length);
        }
        public static float ReadSingle(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadSingle(blockstream);
        }

        public static double ReadDouble(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadDouble(blockstream);
        }

        public static decimal ReadDecimal(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadDecimal(blockstream);
        }

        public static string ReadString(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadString(blockstream);
        }

        public static DateTime ReadDateTime(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadDateTime(blockstream);
        }

        public static TimeSpan ReadTimeSpan(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadTimeSpan(blockstream);
        }

        public static byte ReadUInt08(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadUInt08(blockstream);
        }

        public static ushort ReadUInt16(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadUInt16(blockstream);
        }

        public static uint ReadUInt32(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadUInt32(blockstream);
        }

        public static ulong ReadUInt64(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadUInt64(blockstream);
        }

        public static sbyte ReadInt08(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadInt08(blockstream);
        }

        public static short ReadInt16(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadInt16(blockstream);
        }

        public static int ReadInt32(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadInt32(blockstream);
        }

        public static long ReadInt64(BlockStream_I blockstream)
        {
            return Api.BlockStreams.ReadInt64(blockstream);
        }

        public static void WriteBool(BlockStream_I blockstream, bool value)
        {
            Api.BlockStreams.WriteBool(blockstream, value);
        }

        public static void WriteChar(BlockStream_I blockstream, char value)
        {
            Api.BlockStreams.WriteChar(blockstream, value);
        }

        public static void WriteBytes(BlockStream_I blockstream, byte[] value)
        {
            Api.BlockStreams.WriteBytes(blockstream, value);
        }

        public static void WriteSingle(BlockStream_I blockstream, float value)
        {
            Api.BlockStreams.WriteSingle(blockstream, value);
        }

        public static void WriteDouble(BlockStream_I blockstream, double value)
        {
            Api.BlockStreams.WriteDouble(blockstream, value);
        }

        public static void WriteDecimal(BlockStream_I blockstream, decimal value)
        {
            Api.BlockStreams.WriteDecimal(blockstream, value);
        }

        public static void WriteString(BlockStream_I blockstream, string value)
        {
            Api.BlockStreams.WriteString(blockstream, value);
        }

        public static void WriteDateTime(BlockStream_I blockstream, DateTime value)
        {
            Api.BlockStreams.WriteDateTime(blockstream, value);
        }

        public static void WriteTimeSpan(BlockStream_I blockstream, TimeSpan value)
        {
            Api.BlockStreams.WriteTimeSpan(blockstream, value);
        }

        public static void WriteUInt08(BlockStream_I blockstream, byte value)
        {
            Api.BlockStreams.WriteUInt08(blockstream, value);
        }

        public static void WriteUInt16(BlockStream_I blockstream, ushort value)
        {
            Api.BlockStreams.WriteUInt16(blockstream, value);
        }

        public static void WriteUInt32(BlockStream_I blockstream, uint value)
        {
            Api.BlockStreams.WriteUInt32(blockstream, value);
        }

        public static void WriteUInt64(BlockStream_I blockstream, ulong value)
        {
            Api.BlockStreams.WriteUInt64(blockstream, value);
        }

        public static void WriteInt08(BlockStream_I blockstream, sbyte value)
        {
            Api.BlockStreams.WriteInt08(blockstream, value);
        }

        public static void WriteInt16(BlockStream_I blockstream, short value)
        {
            Api.BlockStreams.WriteInt16(blockstream, value);
        }

        public static void WriteInt32(BlockStream_I blockstream, int value)
        {
            Api.BlockStreams.WriteInt32(blockstream, value);
        }

        public static void WriteInt64(BlockStream_I blockstream, long value)
        {
            Api.BlockStreams.WriteInt64(blockstream, value);
        }
    }
}
