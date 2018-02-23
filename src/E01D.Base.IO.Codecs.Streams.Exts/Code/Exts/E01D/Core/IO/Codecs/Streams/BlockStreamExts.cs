using System;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.IO;
using Root.Code.Models.E01D.Core.IO.Codecs.Streams;

namespace Root.Code.Exts.E01D.Core.IO.Codecs.Streams
{
    public static class BlockStreamExts
    {
        public static bool ReadBool(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadBool(blockstream);
        }

        public static char ReadChar(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadChar(blockstream);
        }

        

        public static byte[] ReadBytes(this BlockStream_I blockstream, int length)
        {
            return XCodecStreams.ReadBytes(blockstream, length);
        }

        public static float ReadSingle(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadSingle(blockstream);
        }

        public static double ReadDouble(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadDouble(blockstream);
        }

        public static decimal ReadDecimal(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadDecimal(blockstream);
        }

        public static string ReadString(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadString(blockstream);
        }

        public static DateTime ReadDateTime(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadDateTime(blockstream);
        }

        public static TimeSpan ReadTimeSpan(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadTimeSpan(blockstream);
        }

        public static byte ReadUInt08(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadUInt08(blockstream);
        }

        public static ushort ReadUInt16(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadUInt16(blockstream);
        }

        public static uint ReadUInt32(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadUInt32(blockstream);
        }

        public static ulong ReadUInt64(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadUInt64(blockstream);
        }

        public static sbyte ReadInt08(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadInt08(blockstream);
        }

        public static short ReadInt16(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadInt16(blockstream);
        }

        public static int ReadInt32(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadInt32(blockstream);
        }

        public static long ReadInt64(this BlockStream_I blockstream)
        {
            return XCodecStreams.ReadInt64(blockstream);
        }


        public static void WriteBool(this BlockStream_I blockstream, bool value)
        {
            XCodecStreams.WriteBool(blockstream, value);
        }

        public static void WriteChar(this BlockStream_I blockstream, char value)
        {
            XCodecStreams.WriteChar(blockstream, value);
        }



        public static void WriteBytes(this BlockStream_I blockstream, byte[] value)
        {
            XCodecStreams.WriteBytes(blockstream, value);
        }

        public static void WriteSingle(this BlockStream_I blockstream, float value)
        {
            XCodecStreams.WriteSingle(blockstream, value);
        }

        public static void WriteDouble(this BlockStream_I blockstream, double value)
        {
            XCodecStreams.WriteDouble(blockstream, value);
        }

        public static void WriteDecimal(this BlockStream_I blockstream, decimal value)
        {
            XCodecStreams.WriteDecimal(blockstream, value);
        }

        public static void WriteString(this BlockStream_I blockstream, string value)
        {
            XCodecStreams.WriteString(blockstream, value);
        }

        public static void WriteDateTime(this BlockStream_I blockstream, DateTime value)
        {
            XCodecStreams.WriteDateTime(blockstream, value);
        }

        public static void WriteTimeSpan(this BlockStream_I blockstream, TimeSpan value)
        {
            XCodecStreams.WriteTimeSpan(blockstream, value);
        }

        public static void WriteUInt08(this BlockStream_I blockstream, byte value)
        {
            XCodecStreams.WriteUInt08(blockstream, value);
        }

        public static void WriteUInt16(this BlockStream_I blockstream, ushort value)
        {
            XCodecStreams.WriteUInt16(blockstream, value);
        }

        public static void WriteUInt32(this BlockStream_I blockstream, uint value)
        {
            XCodecStreams.WriteUInt32(blockstream, value);
        }

        public static void WriteUInt64(this BlockStream_I blockstream, ulong value)
        {
            XCodecStreams.WriteUInt64(blockstream, value);
        }

        public static void WriteInt08(this BlockStream_I blockstream, sbyte value)
        {
            XCodecStreams.WriteInt08(blockstream, value);
        }

        public static void WriteInt16(this BlockStream_I blockstream, short value)
        {
            XCodecStreams.WriteInt16(blockstream, value);
        }

        public static void WriteInt32(this BlockStream_I blockstream, int value)
        {
            XCodecStreams.WriteInt32(blockstream, value);
        }

        public static void WriteInt64(this BlockStream_I blockstream, long value)
        {
            XCodecStreams.WriteInt64(blockstream, value);
        }
    }

}
