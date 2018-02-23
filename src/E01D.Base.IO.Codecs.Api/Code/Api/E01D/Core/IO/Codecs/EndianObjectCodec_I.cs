using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs
{
    public interface EndianObjectCodec_I
    {
        #region Bool

        void WriteBool(byte[] block, int offset, object value);

        void WriteBool(Block_I block, object value);

        object ReadBool(Block_I block);

        object ReadBool(byte[] block, int offset);

        #endregion

        #region Bytes

        void WriteBytes(byte[] block, int offset, object value);

        void WriteBytes(Block_I block, object value);

        object ReadBytes(Block_I block, int length);

        object ReadBytes(byte[] block, int offset, int length);

        #endregion

        #region Char

        void WriteChar(byte[] block, int offset, object value);

        void WriteChar(Block_I block, object value);

        object ReadChar(Block_I block);

        object ReadChar(byte[] block, int offset);

        #endregion

        #region Single

        void WriteSingle(byte[] block, int offset, object value);

        void WriteSingle(Block_I block, object value);

        object ReadSingle(Block_I block);

        object ReadSingle(byte[] block, int offset);

        #endregion

        #region Double

        void WriteDouble(byte[] block, int offset, object value);

        void WriteDouble(Block_I block, object value);

        object ReadDouble(Block_I block);

        object ReadDouble(byte[] block, int offset);

        #endregion

        #region Decimal

        void WriteDecimal(byte[] block, int offset, object value);

        void WriteDecimal(Block_I block, object value);

        object ReadDecimal(Block_I block);

        object ReadDecimal(byte[] block, int offset);

        #endregion

        #region DateTime

        void WriteDateTime(byte[] block, int offset, object value);

        void WriteDateTime(Block_I block, object value);

        object ReadDateTime(Block_I block);

        object ReadDateTime(byte[] block, int offset);

        #endregion

        #region TimeSpan

        void WriteTimeSpan(byte[] block, int offset, object value);

        void WriteTimeSpan(Block_I block, object value);

        object ReadTimeSpan(Block_I block);

        object ReadTimeSpan(byte[] block, int offset);

        #endregion

        #region String

        void WriteString(byte[] block, int offset, object value);

        void WriteString(Block_I block, object value);

        object ReadString(Block_I block);

        object ReadString(byte[] block, int offset);

        #endregion

        #region Int08

        void WriteInt08(byte[] block, int offset, object value);

        void WriteInt08(Block_I block, object value);

        object ReadInt08(Block_I block);

        object ReadInt08(byte[] block, int offset);

        #endregion

        #region Int16

        void WriteInt16(byte[] block, int offset, object value);

        void WriteInt16(Block_I block, object value);

        object ReadInt16(Block_I block);

        object ReadInt16(byte[] block, int offset);

        #endregion

        #region Int32

        void WriteInt32(byte[] block, int offset, object value);

        void WriteInt32(Block_I block, object value);

        object ReadInt32(Block_I block);

        object ReadInt32(byte[] block, int offset);

        #endregion

        #region Int64

        void WriteInt64(byte[] block, int offset, object value);

        void WriteInt64(Block_I block, object value);

        object ReadInt64(Block_I block);

        object ReadInt64(byte[] block, int offset);

        #endregion

        #region UInt08

        void WriteUInt08(byte[] block, int offset, object value);

        void WriteUInt08(Block_I block, object value);

        object ReadUInt08(Block_I block);

        object ReadUInt08(byte[] block, int offset);

        #endregion

        #region UInt16

        void WriteUInt16(byte[] block, int offset, object value);

        void WriteUInt16(Block_I block, object value);

        object ReadUInt16(Block_I block);

        object ReadUInt16(byte[] block, int offset);

        #endregion

        #region UInt32

        void WriteUInt32(byte[] block, int offset, object value);

        void WriteUInt32(Block_I block, object value);

        object ReadUInt32(Block_I block);

        object ReadUInt32(byte[] block, int offset);

        #endregion

        #region UInt64

        void WriteUInt64(byte[] block, int offset, object value);

        void WriteUInt64(Block_I block, object value);

        object ReadUInt64(Block_I block);

        object ReadUInt64(byte[] block, int offset);

        #endregion
    }
}
