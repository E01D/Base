using System;
using Root.Code.Api.E01D.Core.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Domains.E01D
{
    public static class XCodecs
    {
        
        public static CodecApi Api { get; set; } = new CodecApi();

        public static byte[] ReadBytes(Block_I block, int length)
        {
            return Api.LittleEndian.ReadBytes(block, length);
        }

        public static bool ReadBool(Block_I block)
        {
            return Api.LittleEndian.ReadBool(block);
        }

        public static char ReadChar(Block_I block)
        {
            return Api.LittleEndian.ReadChar(block);
        }

        public static char ReadAsciiChar(Block_I block)
        {
            return Api.LittleEndian.ReadAsciiChar(block);
        }

        public static double ReadDouble(Block_I block)
        {
            return Api.LittleEndian.ReadDouble(block);
        }

        public static float ReadSingle(Block_I block)
        {
            return Api.LittleEndian.ReadSingle(block);
        }

        public static DateTime ReadDateTime(Block_I block)
        {
            return Api.LittleEndian.ReadDateTime(block);
        }

        public static TimeSpan ReadTimeSpan(Block_I block)
        {
            return Api.LittleEndian.ReadTimeSpan(block);
        }

        public static decimal ReadDecimal(Block_I block)
        {
            return Api.LittleEndian.ReadDecimal(block);
        }

        public static string ReadString(Block_I block)
        {
            return Api.LittleEndian.ReadString(block);
        }

        public static byte ReadUInt08(Block_I block)
        {
            return Api.LittleEndian.ReadUInt08(block);
        }

        public static ushort ReadUInt16(Block_I block)
        {
            return Api.LittleEndian.ReadUInt16(block);
        }

        public static uint ReadUInt32(Block_I block)
        {
            return Api.LittleEndian.ReadUInt32(block);
        }

        public static ulong ReadUInt64(Block_I block)
        {
            return Api.LittleEndian.ReadUInt64(block);
        }

        public static sbyte ReadInt08(Block_I block)
        {
            return Api.LittleEndian.ReadInt08(block);
        }

        public static short ReadInt16(Block_I block)
        {
            return Api.LittleEndian.ReadInt16(block);
        }

        public static int ReadInt32(Block_I block)
        {
            return Api.LittleEndian.ReadInt32(block);
        }

        public static long ReadInt64(Block_I block)
        {
            return Api.LittleEndian.ReadInt64(block);
        }

        public static void WriteBool(Block_I block, bool value)
        {
            Api.LittleEndian.WriteBool(block, value);
        }

        public static void WriteChar(Block_I block, char value)
        {
            Api.LittleEndian.WriteChar(block, value);
        }

        public static void WriteAsciiChar(Block_I block, char value)
        {
            Api.LittleEndian.WriteAsciiChar(block, value);
        }

        public static void WriteBytes(Block_I block, byte[] value)
        {
            Api.LittleEndian.WriteBytes(block, value);
        }

        public static void WriteSingle(Block_I block, float value)
        {
            Api.LittleEndian.WriteSingle(block, value);
        }

        public static void WriteDouble(Block_I block, double value)
        {
            Api.LittleEndian.WriteDouble(block, value);
        }

        public static void WriteDecimal(Block_I block, decimal value)
        {
            Api.LittleEndian.WriteDecimal(block, value);
        }

        public static void WriteString(Block_I block, string value)
        {
            Api.LittleEndian.WriteString(block, value);
        }

        public static void WriteDateTime(Block_I block, DateTime value)
        {
            Api.LittleEndian.WriteDateTime(block, value);
        }

        public static void WriteTimeSpan(Block_I block, TimeSpan value)
        {
            Api.LittleEndian.WriteTimeSpan(block, value);
        }

        public static void WriteUInt08(Block_I block, byte value)
        {
            Api.LittleEndian.WriteUInt08(block, value);
        }

        public static void WriteUInt16(Block_I block, ushort value)
        {
            Api.LittleEndian.WriteUInt16(block, value);
        }

        public static void WriteUInt32(Block_I block, uint value)
        {
            Api.LittleEndian.WriteUInt32(block, value);
        }

        public static void WriteUInt64(Block_I block, ulong value)
        {
            Api.LittleEndian.WriteUInt64(block, value);
        }

        public static void WriteInt08(Block_I block, sbyte value)
        {
            Api.LittleEndian.WriteInt08(block, value);
        }

        public static void WriteInt16(Block_I block, short value)
        {
            Api.LittleEndian.WriteInt16(block, value);
        }

        public static void WriteInt32(Block_I block, int value)
        {
            Api.LittleEndian.WriteInt32(block, value);
        }

        public static void WriteInt64(Block_I block, long value)
        {
            Api.LittleEndian.WriteInt64(block, value);
        }

        public static char[] ReadAsciiChars(Block_I block, int length)
        {
            return Api.LittleEndian.ReadAsciiChars(block, length);
        }


    }
}
