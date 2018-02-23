using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class FlagsApi: FlagsApi_I
    {
        public int ByteLength(BitFlagArray array)
        {
            return array.Bytes.Length;   
        }

        public void Copy(BitFlagArray array, byte[] buffer, int startingPosition)
        {
            System.Array.Copy(array.Bytes, 0, buffer, startingPosition, array.Bytes.Length);
        }

        public byte GetByteAt(BitFlagArray array, int byteIndex)
        {
            return array.Bytes[byteIndex];
        }

        public bool IsBitTrue(BitFlagArray array, int bitNumber)
        {
            return (array.Bytes[CalculateBitOffset(bitNumber)] >> (CalculateByteOffset(bitNumber) & 0x1f) & 1) != 0;
        }

        public bool IsFlagTrue(BitFlagArray array, ushort flag)
        {
            var bitToCheck = -1;

            var newFlag = 0;

            // 1,       2,      4,      8
            // 16,      32,     64,     128
            // 256,     512,    1024,   2048
            // 2048,    4096,   8192,   16384

            for (var iGroup = 3; iGroup >= 0; iGroup--)
            {
                if ((newFlag = (flag >> iGroup)) > 0)
                {
                    if (newFlag == 1)
                    {
                        bitToCheck = 1 + iGroup * 4;
                    }
                    else if (newFlag == 2)
                    {
                        bitToCheck = 2 + iGroup * 4;
                    }
                    else if (newFlag == 4)
                    {
                        bitToCheck = 3 + iGroup * 4;
                    }
                    else if (newFlag == 8)
                    {
                        bitToCheck = 4 + iGroup * 4;
                    }

                    if (bitToCheck != -1)
                    {
                        return IsBitTrue(array, bitToCheck);
                    }
                }
            }

            return false;
        }

        public bool IsBitFalse(BitFlagArray array, int bitNumber)
        {
            return !IsBitTrue(array, bitNumber);
        }

        public void SetBit(BitFlagArray array, int bitNumber, bool newValue)
        {
            if (newValue)
            {
                SetBitTrue(array, bitNumber);

                return;
            }

            SetBitFalse(array, bitNumber);
        }

        public void SetBitTrue(BitFlagArray array, int bitNumber)
        {
            array.Bytes[CalculateBitOffset(bitNumber)] |= CalculateBitMask(bitNumber);
        }

        public void SetBitFalse(BitFlagArray array, int bitNumber)
        {
            // using the ~ returns an int; have to turn it back into a byte
            array.Bytes[CalculateBitOffset(bitNumber)] &= (byte)~CalculateBitMask(bitNumber);
        }

        public void SetByteAt(BitFlagArray array, int byteIndex, byte byteValue)
        {
            array.Bytes[byteIndex] = byteValue;
        }





        public int CalculateBitOffset(int bitNumber)
        {
            return bitNumber / 8;
        }

        public byte CalculateBitMask(int bitNumber)
        {
            return (byte)(1 << CalculateByteOffset(bitNumber));
        }

        public byte CalculateByteOffset(int bitNumber)
        {
            return (byte)(bitNumber % 8);
        }

        public int CalculateNumberOfBytes(int numberOfBits)
        {
            return (numberOfBits + 7) / 8; // gets rounded to 1.
        }

        

        public bool IsBitSet(long flags, uint bit)
        {
            if (bit > 0)
            {
                return (flags & (bit * 2)) > 0;
            }
            else
            {
                return (flags & 1) > 0;
            }
        }

        internal static long BitSet(long flags, uint bit, bool state)
        {
            if (state)
            {
                if (bit > 0)
                {
                    return flags |= (bit * 2);
                }
                else
                {
                    return flags |= 1;
                }
            }
            else
            {
                if (bit > 0)
                {
                    return flags &= ~(bit * 2);
                }
                else
                {
                    return flags &= ~1;
                }
            }
        }
    }
}
