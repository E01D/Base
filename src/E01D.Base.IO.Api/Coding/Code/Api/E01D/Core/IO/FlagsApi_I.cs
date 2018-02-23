using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public interface FlagsApi_I
    {
        int ByteLength(BitFlagArray flags);

        void Copy(BitFlagArray flags, byte[] buffer, int startingPosition);

        byte GetByteAt(BitFlagArray flags, int byteIndex);

        bool IsBitTrue(BitFlagArray flags, int bitNumber);

        bool IsFlagTrue(BitFlagArray flags, ushort flag);

        bool IsBitFalse(BitFlagArray flags, int bitNumber);

        void SetBit(BitFlagArray flags, int bitNumber, bool newValue);

        void SetBitTrue(BitFlagArray flags, int bitNumber);

        void SetBitFalse(BitFlagArray flags, int bitNumber);

        void SetByteAt(BitFlagArray flags, int byteIndex, byte byteValue);
    }
}
