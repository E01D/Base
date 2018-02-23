using Root.Code.Models.E01D.Core.IO;
using Root.Code.Shortcuts.E01D;

namespace Root.Code.Exts.E01D.IO
{
    public static class BlockExt
    {
        public static void Write(this Block_I block, bool data)
        {
            XTransceiving.Api.Transceivers.Bool.Write(block, data);
        }

        public static void Read(this Block_I block, bool data)
        {
            XTransceiving.Api.Transceivers.Bool.Read(block, out data);
        }

        public static void Write(this Block_I block, byte[] data)
        {
            XTransceiving.Api.Transceivers.UInt08.Write(block, data);
        }

        public static void Read(this Block_I block, byte[] data)
        {
            XTransceiving.Api.Transceivers.UInt08.Read(block, data);
        }

        public static void Write(this Block_I block, byte[] data, long length)
        {
            XTransceiving.Api.Transceivers.UInt08.Write(block, data, length);
        }

        public static void Read(this Block_I block, byte[] data, long length)
        {
            XTransceiving.Api.Transceivers.UInt08.Read(block, data, length);
        }

        public static void Write(this Block_I block, byte[] data, long offset, long length)
        {
            XTransceiving.Api.Transceivers.UInt08.Write(block, data, offset, length);
        }

        public static void Read(this Block_I block, byte[] data, long offset, long length)
        {
            XTransceiving.Api.Transceivers.UInt08.Read(block, data, offset, length);
        }

        public static void Write(this Block_I block, sbyte data)
        {
            XTransceiving.Api.Transceivers.Int08.Write(block, data);
        }

        public static void Read(this Block_I block, out sbyte data)
        {
            XTransceiving.Api.Transceivers.Int08.Read(block, out data);
        }

        public static void Write(this Block_I block, short data)
        {
            XTransceiving.Api.Transceivers.Int16.Write(block, data);
        }

        public static void Read(this Block_I block, out short data)
        {
            XTransceiving.Api.Transceivers.Int16.Read(block, out data);
        }

        public static void Write(this Block_I block, int data)
        {
            XTransceiving.Api.Transceivers.Int32.Write(block, data);
        }

        public static void Read(this Block_I block, out int data)
        {
            XTransceiving.Api.Transceivers.Int32.Read(block, out data);
        }

        public static void Write(this Block_I block, long valueToWrite)
        {
            XTransceiving.Api.Transceivers.Int64.Write(block, valueToWrite);
        }

        public static void Read(this Block_I block, out long valueToRead)
        {
            XTransceiving.Api.Transceivers.Int64.Read(block, out valueToRead);
        }

        public static void Write(this Block_I block, byte data)
        {
            XTransceiving.Api.Transceivers.UInt08.Write(block, data);
        }

        public static void Read(this Block_I block, out byte data)
        {
            XTransceiving.Api.Transceivers.UInt08.Read(block, out data);
        }

        public static void Write(this Block_I block, ushort data)
        {
            XTransceiving.Api.Transceivers.UInt16.Write(block, data);
        }

        public static void Read(this Block_I block, out ushort data)
        {
            XTransceiving.Api.Transceivers.UInt16.Read(block, out data);
        }

        public static void Write(this Block_I block, uint data)
        {
            XTransceiving.Api.Transceivers.UInt32.Write(block, data);
        }

        public static void Read(this Block_I block, out uint data)
        {
            XTransceiving.Api.Transceivers.UInt32.Read(block, out data);
        }

        public static void Write(this Block_I block, ulong valueToWrite)
        {
            XTransceiving.Api.Transceivers.UInt64.Write(block, valueToWrite);
        }

        public static void Read(this Block_I block, out ulong valueToRead)
        {
            XTransceiving.Api.Transceivers.UInt64.Read(block, out valueToRead);
        }

        public static void Write(this Block_I block, char valueToWrite)
        {
            XTransceiving.Api.Transceivers.Char.Write(block, valueToWrite);
        }

        public static void Read(this Block_I block, out char valueToRead)
        {
            XTransceiving.Api.Transceivers.Char.Read(block, out valueToRead);
        }

        public static void Write(this Block_I block, string valueToWrite)
        {
            XTransceiving.Api.Transceivers.String.Write(block, valueToWrite);
        }

        public static void Read(this Block_I block, out string valueToRead)
        {
            XTransceiving.Api.Transceivers.String.Read(block, out valueToRead);
        }
    }
}
