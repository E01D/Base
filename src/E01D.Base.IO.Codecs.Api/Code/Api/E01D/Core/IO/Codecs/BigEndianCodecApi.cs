using System;
using Root.Code.Api.E01D.Core.IO.Codecs.BigEndian;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs
{
    public class BigEndianCodecApi:EndianCodec_I
    {
        #region Properties

        public BoolApi Bool { get; set; } = new BoolApi();

        public CharApi Char { get; set; } = new CharApi();

        public StringApi String { get; set; } = new StringApi();

        public DecimalApi Decimal { get; set; } = new DecimalApi();

        public DoubleApi Double { get; set; } = new DoubleApi();

        public SingleApi Single { get; set; } = new SingleApi();



        public DateTimeApi DateTime { get; set; } = new DateTimeApi();

        public TimeSpanApi TimeSpan { get; set; } = new TimeSpanApi();

        public Int08Api Int08 { get; set; } = new Int08Api();
        public Int16Api Int16 { get; set; } = new Int16Api();
        public Int32Api Int32 { get; set; } = new Int32Api();
        public Int64Api Int64 { get; set; } = new Int64Api();
        public UInt08Api UInt08 { get; set; } = new UInt08Api();
        public UInt16Api UInt16 { get; set; } = new UInt16Api();
        public UInt32Api UInt32 { get; set; } = new UInt32Api();
        public UInt64Api UInt64 { get; set; } = new UInt64Api();

        #endregion



        #region Bool - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadBool(Block_I block)
        {
            return Bool.Read(block);
        }

        object EndianObjectCodec_I.ReadBool(byte[] block, int offset)
        {
            return Bool.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteBool(Block_I block, object value)
        {
            ((ObjectCodec_I)Bool).Write(block, value);
        }

        void EndianObjectCodec_I.WriteBool(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Bool).Write(block, offset, value);
        }

        #endregion

        #region Bool

        public bool ReadBool(Block_I block)
        {
            return Bool.Read(block);
        }

        public bool ReadBool(byte[] block, int position)
        {
            return Bool.Read(block, position);
        }

        public void WriteBool(Block_I block, bool value)
        {
            Bool.Write(block, value);
        }

        public void WriteBool(byte[] block, int position, bool value)
        {
            Bool.Write(block, position, value);
        }

        #endregion

        #region Bytes - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadBytes(Block_I block, int length)
        {
            return UInt08.Read(block, length);
        }

        object EndianObjectCodec_I.ReadBytes(byte[] block, int offset, int length)
        {
            return UInt08.Read(block, offset, length);
        }

        void EndianObjectCodec_I.WriteBytes(Block_I block, object value)
        {
            UInt08.Write(block.Data, block.Position, (byte[])value);
        }

        void EndianObjectCodec_I.WriteBytes(byte[] block, int offset, object value)
        {
            UInt08.Write(block, offset, (byte[])value);
        }

        #endregion

        #region Bytes

        public byte[] ReadBytes(Block_I block, int length)
        {
            return UInt08.Read(block, length);
        }

        public void WriteBytes(Block_I block, byte[] value)
        {
            UInt08.Write(block.Data, block.Position, value);
        }

        public byte[] ReadBytes(byte[] block, int offset, int length)
        {
            return UInt08.Read(block, offset, length);
        }

        public void WriteBytes(byte[] block, int offset, byte[] value)
        {
            UInt08.Write(block, offset, value);
        }

        #endregion

        #region Char - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadChar(Block_I block)
        {
            return Char.Read(block);
        }

        object EndianObjectCodec_I.ReadChar(byte[] block, int offset)
        {
            return Char.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteChar(Block_I block, object value)
        {
            ((ObjectCodec_I)Char).Write(block, value);
        }

        void EndianObjectCodec_I.WriteChar(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Char).Write(block, offset, value);
        }

        #endregion

        #region Char

        public char ReadChar(Block_I block)
        {
            return Char.Read(block);
        }

        public char ReadChar(byte[] block, int position)
        {
            return Char.Read(block, position);
        }

        public void WriteChar(Block_I block, char value)
        {
            Char.Write(block, value);
        }

        public void WriteChar(byte[] block, int position, char value)
        {
            Char.Write(block, position, value);
        }

        #endregion

        #region Single - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadSingle(Block_I block)
        {
            return Single.Read(block);
        }

        object EndianObjectCodec_I.ReadSingle(byte[] block, int offset)
        {
            return Single.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteSingle(Block_I block, object value)
        {
            ((ObjectCodec_I)Single).Write(block, value);
        }

        void EndianObjectCodec_I.WriteSingle(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Single).Write(block, offset, value);
        }

        #endregion

        #region Single

        public float ReadSingle(Block_I block)
        {
            return Single.Read(block);
        }

        public float ReadSingle(byte[] block, int position)
        {
            return Single.Read(block, position);
        }

        public void WriteSingle(Block_I block, float value)
        {
            Single.Write(block, value);
        }

        public void WriteSingle(byte[] block, int position, float value)
        {
            Single.Write(block, position, value);
        }

        #endregion

        #region Double - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadDouble(Block_I block)
        {
            return Double.Read(block);
        }

        object EndianObjectCodec_I.ReadDouble(byte[] block, int offset)
        {
            return Double.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteDouble(Block_I block, object value)
        {
            ((ObjectCodec_I)Double).Write(block, value);
        }

        void EndianObjectCodec_I.WriteDouble(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Double).Write(block, offset, value);
        }

        #endregion

        #region Double

        public double ReadDouble(Block_I block)
        {
            return Double.Read(block);
        }

        public double ReadDouble(byte[] block, int position)
        {
            return Double.Read(block, position);
        }

        public void WriteDouble(Block_I block, double value)
        {
            Double.Write(block, value);
        }

        public void WriteDouble(byte[] block, int position, double value)
        {
            Double.Write(block, position, value);
        }

        #endregion

        #region Decimal - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadDecimal(Block_I block)
        {
            return Decimal.Read(block);
        }

        object EndianObjectCodec_I.ReadDecimal(byte[] block, int offset)
        {
            return Decimal.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteDecimal(Block_I block, object value)
        {
            ((ObjectCodec_I)Decimal).Write(block, value);
        }

        void EndianObjectCodec_I.WriteDecimal(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Decimal).Write(block, offset, value);
        }

        #endregion

        #region Decimal

        public decimal ReadDecimal(Block_I block)
        {
            return Decimal.Read(block);
        }

        public decimal ReadDecimal(byte[] block, int position)
        {
            return Decimal.Read(block, position);
        }

        public void WriteDecimal(Block_I block, decimal value)
        {
            Decimal.Write(block, value);
        }

        public void WriteDecimal(byte[] block, int position, decimal value)
        {
            Decimal.Write(block, position, value);
        }

        #endregion

        #region DateTime - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadDateTime(Block_I block)
        {
            return DateTime.Read(block);
        }

        object EndianObjectCodec_I.ReadDateTime(byte[] block, int offset)
        {
            return DateTime.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteDateTime(Block_I block, object value)
        {
            ((ObjectCodec_I)DateTime).Write(block, value);
        }

        void EndianObjectCodec_I.WriteDateTime(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)DateTime).Write(block, offset, value);
        }

        #endregion

        #region DateTime

        public DateTime ReadDateTime(Block_I block)
        {
            return DateTime.Read(block);
        }

        public DateTime ReadDateTime(byte[] block, int position)
        {
            return DateTime.Read(block, position);
        }

        public void WriteDateTime(Block_I block, DateTime value)
        {
            DateTime.Write(block, value);
        }

        public void WriteDateTime(byte[] block, int position, DateTime value)
        {
            DateTime.Write(block, position, value);
        }

        #endregion

        #region TimeSpan - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadTimeSpan(Block_I block)
        {
            return TimeSpan.Read(block);
        }

        object EndianObjectCodec_I.ReadTimeSpan(byte[] block, int offset)
        {
            return TimeSpan.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteTimeSpan(Block_I block, object value)
        {
            ((ObjectCodec_I)TimeSpan).Write(block, value);
        }

        void EndianObjectCodec_I.WriteTimeSpan(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)TimeSpan).Write(block, offset, value);
        }

        #endregion

        #region TimeSpan

        public TimeSpan ReadTimeSpan(Block_I block)
        {
            return TimeSpan.Read(block);
        }

        public TimeSpan ReadTimeSpan(byte[] block, int position)
        {
            return TimeSpan.Read(block, position);
        }

        public void WriteTimeSpan(Block_I block, TimeSpan value)
        {
            TimeSpan.Write(block, value);
        }

        public void WriteTimeSpan(byte[] block, int position, TimeSpan value)
        {
            TimeSpan.Write(block, position, value);
        }

        #endregion

        #region String - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadString(Block_I block)
        {
            return String.Read(block);
        }

        object EndianObjectCodec_I.ReadString(byte[] block, int offset)
        {
            return String.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteString(Block_I block, object value)
        {
            ((ObjectCodec_I)String).Write(block, value);
        }

        void EndianObjectCodec_I.WriteString(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)String).Write(block, offset, value);
        }

        #endregion

        #region String

        public string ReadString(Block_I block)
        {
            return String.Read(block);
        }

        public string ReadString(byte[] block, int position)
        {
            return String.Read(block, position);
        }

        public void WriteString(Block_I block, string value)
        {
            String.Write(block, value);
        }

        public void WriteString(byte[] block, int position, string value)
        {
            String.Write(block, position, value);
        }

        public string ReadUTF16String(Block_I block)
        {
            return String.ReadUTF16String(block.Data, block.Position);
        }

        #endregion

        #region Int08 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadInt08(Block_I block)
        {
            return Int08.Read(block);
        }

        object EndianObjectCodec_I.ReadInt08(byte[] block, int offset)
        {
            return Int08.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteInt08(Block_I block, object value)
        {
            ((ObjectCodec_I)Int08).Write(block, value);
        }

        void EndianObjectCodec_I.WriteInt08(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Int08).Write(block, offset, value);
        }

        #endregion

        #region Int08

        public sbyte ReadInt08(Block_I block)
        {
            return Int08.Read(block);
        }

        public sbyte ReadInt08(byte[] block, int position)
        {
            return Int08.Read(block, position);
        }

        public void WriteInt08(Block_I block, sbyte value)
        {
            Int08.Write(block, value);
        }

        public void WriteInt08(byte[] block, int position, sbyte value)
        {
            Int08.Write(block, position, value);
        }

        #endregion

        #region Int16 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadInt16(Block_I block)
        {
            return Int16.Read(block);
        }

        object EndianObjectCodec_I.ReadInt16(byte[] block, int offset)
        {
            return Int16.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteInt16(Block_I block, object value)
        {
            ((ObjectCodec_I)Int16).Write(block, value);
        }

        void EndianObjectCodec_I.WriteInt16(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Int16).Write(block, offset, value);
        }

        #endregion

        #region Int16

        public short ReadInt16(Block_I block)
        {
            return Int16.Read(block);
        }

        public short ReadInt16(byte[] block, int position)
        {
            return Int16.Read(block, position);
        }

        public void WriteInt16(Block_I block, short value)
        {
            Int16.Write(block, value);
        }

        public void WriteInt16(byte[] block, int position, short value)
        {
            Int16.Write(block, position, value);
        }

        #endregion

        #region Int32 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadInt32(Block_I block)
        {
            return Int32.Read(block);
        }

        object EndianObjectCodec_I.ReadInt32(byte[] block, int offset)
        {
            return Int32.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteInt32(Block_I block, object value)
        {
            ((ObjectCodec_I)Int32).Write(block, value);
        }

        void EndianObjectCodec_I.WriteInt32(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Int32).Write(block, offset, value);
        }

        #endregion

        #region Int32

        public int ReadInt32(Block_I block)
        {
            return Int32.Read(block);
        }

        public int ReadInt32(byte[] block, int position)
        {
            return Int32.Read(block, position);
        }

        public void WriteInt32(Block_I block, int value)
        {
            Int32.Write(block, value);
        }

        public void WriteInt32(byte[] block, int position, int value)
        {
            Int32.Write(block, position, value);
        }

        #endregion

        #region Int64 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadInt64(Block_I block)
        {
            return Int64.Read(block);
        }

        object EndianObjectCodec_I.ReadInt64(byte[] block, int offset)
        {
            return Int64.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteInt64(Block_I block, object value)
        {
            ((ObjectCodec_I)Int64).Write(block, value);
        }

        void EndianObjectCodec_I.WriteInt64(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)Int64).Write(block, offset, value);
        }

        #endregion

        #region Int64

        public long ReadInt64(Block_I block)
        {
            return Int64.Read(block);
        }

        public long ReadInt64(byte[] block, int position)
        {
            return Int64.Read(block, position);
        }

        public void WriteInt64(Block_I block, long value)
        {
            Int64.Write(block, value);
        }

        public void WriteInt64(byte[] block, int position, long value)
        {
            Int64.Write(block, position, value);
        }

        #endregion

        #region UInt08 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadUInt08(Block_I block)
        {
            return UInt08.Read(block);
        }

        object EndianObjectCodec_I.ReadUInt08(byte[] block, int offset)
        {
            return UInt08.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteUInt08(Block_I block, object value)
        {
            ((ObjectCodec_I)UInt08).Write(block, value);
        }

        void EndianObjectCodec_I.WriteUInt08(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)UInt08).Write(block, offset, value);
        }

        #endregion

        #region UInt08

        public byte ReadUInt08(Block_I block)
        {
            return UInt08.Read(block);
        }

        public byte ReadUInt08(byte[] block, int position)
        {
            return UInt08.Read(block, position);
        }

        public void WriteUInt08(Block_I block, byte value)
        {
            UInt08.Write(block, value);
        }

        public void WriteUInt08(byte[] block, int position, byte value)
        {
            UInt08.Write(block, position, value);
        }

        #endregion

        #region UInt16 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadUInt16(Block_I block)
        {
            return UInt16.Read(block);
        }

        object EndianObjectCodec_I.ReadUInt16(byte[] block, int offset)
        {
            return UInt16.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteUInt16(Block_I block, object value)
        {
            ((ObjectCodec_I)UInt16).Write(block, value);
        }

        void EndianObjectCodec_I.WriteUInt16(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)UInt16).Write(block, offset, value);
        }

        #endregion

        #region UInt16

        public ushort ReadUInt16(Block_I block)
        {
            return UInt16.Read(block);
        }

        public ushort ReadUInt16(byte[] block, int position)
        {
            return UInt16.Read(block, position);
        }

        public void WriteUInt16(Block_I block, ushort value)
        {
            UInt16.Write(block, value);
        }

        public void WriteUInt16(byte[] block, int position, ushort value)
        {
            UInt16.Write(block, position, value);
        }

        #endregion

        #region UInt32 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadUInt32(Block_I block)
        {
            return UInt32.Read(block);
        }

        object EndianObjectCodec_I.ReadUInt32(byte[] block, int offset)
        {
            return UInt32.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteUInt32(Block_I block, object value)
        {
            ((ObjectCodec_I)UInt32).Write(block, value);
        }

        void EndianObjectCodec_I.WriteUInt32(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)UInt32).Write(block, offset, value);
        }

        #endregion

        #region UInt32

        public uint ReadUInt32(Block_I block)
        {
            return UInt32.Read(block);
        }

        public uint ReadUInt32(byte[] block, int position)
        {
            return UInt32.Read(block, position);
        }

        public void WriteUInt32(Block_I block, uint value)
        {
            UInt32.Write(block, value);
        }

        public void WriteUInt32(byte[] block, int position, uint value)
        {
            UInt32.Write(block, position, value);
        }

        #endregion

        #region UInt64 - EndianObjectCodec_I

        object EndianObjectCodec_I.ReadUInt64(Block_I block)
        {
            return UInt64.Read(block);
        }

        object EndianObjectCodec_I.ReadUInt64(byte[] block, int offset)
        {
            return UInt64.Read(block, offset);
        }

        void EndianObjectCodec_I.WriteUInt64(Block_I block, object value)
        {
            ((ObjectCodec_I)UInt64).Write(block, value);
        }

        void EndianObjectCodec_I.WriteUInt64(byte[] block, int offset, object value)
        {
            ((ObjectCodec_I)UInt64).Write(block, offset, value);
        }

        #endregion

        #region UInt64

        public ulong ReadUInt64(Block_I block)
        {
            return UInt64.Read(block);
        }

        public ulong ReadUInt64(byte[] block, int position)
        {
            return UInt64.Read(block, position);
        }

        public void WriteUInt64(Block_I block, ulong value)
        {
            UInt64.Write(block, value);
        }

        public void WriteUInt64(byte[] block, int position, ulong value)
        {
            UInt64.Write(block, position, value);
        }

        #endregion
    }
}
