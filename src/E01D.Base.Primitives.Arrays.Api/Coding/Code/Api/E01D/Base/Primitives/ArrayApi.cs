using System;
using System.Text;

namespace Root.Coding.Code.Api.E01D.Base.Primitives
{
    public class ArrayApi
    {
        public T[] Slice<T>(T[] source, int start, int end)
        {
            
            if (end < 0)
            {
                end = source.Length + end;
            }

            int length = end - start;

            
            T[] res = new T[length];

            for (int i = 0; i < length; i++)
            {
                res[i] = source[i + start];
            }

            return res;
        }

        public void TaReverse<T>(T[] array)
        {

            var i = 0;
            var n = array.Length;
            var middle = Math.Floor((double)n / 2);
            T temp;

            for (; i < middle; i += 1)
            {
                temp = array[i];
                array[i] = array[n - 1 - i];
                array[n - 1 - i] = temp;
            }
        }

        public bool AreEqual(
            bool[] a,
            bool[] b)
        {
            if (a == b)
                return true;

            if (a == null || b == null)
                return false;

            return HaveSameContents(a, b);
        }

        public bool AreEqual(
            char[] a,
            char[] b)
        {
            if (a == b)
                return true;

            if (a == null || b == null)
                return false;

            return HaveSameContents(a, b);
        }

        /// <summary>
        /// Are two arrays equal.
        /// </summary>
        /// <param name="a">Left side.</param>
        /// <param name="b">Right side.</param>
        /// <returns>True if equal.</returns>
        public bool AreEqual(
            byte[] a,
            byte[] b)
        {
            if (a == b)
                return true;

            if (a == null || b == null)
                return false;

            return HaveSameContents(a, b);
        }

        [Obsolete("Use 'AreEqual' method instead")]
        public bool AreSame(
            byte[] a,
            byte[] b)
        {
            return AreEqual(a, b);
        }

        /// <summary>
        /// A constant time equals comparison - does not terminate early if
        /// test will fail.
        /// </summary>
        /// <param name="a">first array</param>
        /// <param name="b">second array</param>
        /// <returns>true if arrays equal, false otherwise.</returns>
        public bool ConstantTimeAreEqual(
            byte[] a,
            byte[] b)
        {
            int i = a.Length;
            if (i != b.Length)
                return false;
            int cmp = 0;
            while (i != 0)
            {
                --i;
                cmp |= (a[i] ^ b[i]);
            }
            return cmp == 0;
        }

        public bool AreEqual(
            int[] a,
            int[] b)
        {
            if (a == b)
                return true;

            if (a == null || b == null)
                return false;

            return HaveSameContents(a, b);
        }

        [CLSCompliant(false)]
        public bool AreEqual(uint[] a, uint[] b)
        {
            if (a == b)
                return true;

            if (a == null || b == null)
                return false;

            return HaveSameContents(a, b);
        }

        private static bool HaveSameContents(
            bool[] a,
            bool[] b)
        {
            int i = a.Length;
            if (i != b.Length)
                return false;
            while (i != 0)
            {
                --i;
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static bool HaveSameContents(
            char[] a,
            char[] b)
        {
            int i = a.Length;
            if (i != b.Length)
                return false;
            while (i != 0)
            {
                --i;
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static bool HaveSameContents(
            byte[] a,
            byte[] b)
        {
            int i = a.Length;
            if (i != b.Length)
                return false;
            while (i != 0)
            {
                --i;
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static bool HaveSameContents(
            int[] a,
            int[] b)
        {
            int i = a.Length;
            if (i != b.Length)
                return false;
            while (i != 0)
            {
                --i;
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static bool HaveSameContents(uint[] a, uint[] b)
        {
            int i = a.Length;
            if (i != b.Length)
                return false;
            while (i != 0)
            {
                --i;
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        public string ToString(
            object[] a)
        {
            StringBuilder sb = new StringBuilder('[');
            if (a.Length > 0)
            {
                sb.Append(a[0]);
                for (int index = 1; index < a.Length; ++index)
                {
                    sb.Append(", ").Append(a[index]);
                }
            }
            sb.Append(']');
            return sb.ToString();
        }

        public int GetHashCode(byte[] data)
        {
            if (data == null)
            {
                return 0;
            }

            int i = data.Length;
            int hc = i + 1;

            while (--i >= 0)
            {
                hc *= 257;
                hc ^= data[i];
            }

            return hc;
        }

        public int GetHashCode(byte[] data, int off, int len)
        {
            if (data == null)
            {
                return 0;
            }

            int i = len;
            int hc = i + 1;

            while (--i >= 0)
            {
                hc *= 257;
                hc ^= data[off + i];
            }

            return hc;
        }

        public int GetHashCode(int[] data)
        {
            if (data == null)
                return 0;

            int i = data.Length;
            int hc = i + 1;

            while (--i >= 0)
            {
                hc *= 257;
                hc ^= data[i];
            }

            return hc;
        }

        public int GetHashCode(int[] data, int off, int len)
        {
            if (data == null)
                return 0;

            int i = len;
            int hc = i + 1;

            while (--i >= 0)
            {
                hc *= 257;
                hc ^= data[off + i];
            }

            return hc;
        }

        [CLSCompliant(false)]
        public int GetHashCode(uint[] data)
        {
            if (data == null)
                return 0;

            int i = data.Length;
            int hc = i + 1;

            while (--i >= 0)
            {
                hc *= 257;
                hc ^= (int)data[i];
            }

            return hc;
        }

        [CLSCompliant(false)]
        public int GetHashCode(uint[] data, int off, int len)
        {
            if (data == null)
                return 0;

            int i = len;
            int hc = i + 1;

            while (--i >= 0)
            {
                hc *= 257;
                hc ^= (int)data[off + i];
            }

            return hc;
        }

        [CLSCompliant(false)]
        public int GetHashCode(ulong[] data)
        {
            if (data == null)
                return 0;

            int i = data.Length;
            int hc = i + 1;

            while (--i >= 0)
            {
                ulong di = data[i];
                hc *= 257;
                hc ^= (int)di;
                hc *= 257;
                hc ^= (int)(di >> 32);
            }

            return hc;
        }

        [CLSCompliant(false)]
        public int GetHashCode(ulong[] data, int off, int len)
        {
            if (data == null)
                return 0;

            int i = len;
            int hc = i + 1;

            while (--i >= 0)
            {
                ulong di = data[off + i];
                hc *= 257;
                hc ^= (int)di;
                hc *= 257;
                hc ^= (int)(di >> 32);
            }

            return hc;
        }

        public byte[] Clone(
            byte[] data)
        {
            return data == null ? null : (byte[])data.Clone();
        }

        public byte[] Clone(
            byte[] data,
            byte[] existing)
        {
            if (data == null)
            {
                return null;
            }
            if ((existing == null) || (existing.Length != data.Length))
            {
                return Clone(data);
            }
            Array.Copy(data, 0, existing, 0, existing.Length);
            return existing;
        }

        public int[] Clone(
            int[] data)
        {
            return data == null ? null : (int[])data.Clone();
        }

        internal static uint[] Clone(uint[] data)
        {
            return data == null ? null : (uint[])data.Clone();
        }

        public long[] Clone(long[] data)
        {
            return data == null ? null : (long[])data.Clone();
        }

        [CLSCompliant(false)]
        public ulong[] Clone(
            ulong[] data)
        {
            return data == null ? null : (ulong[])data.Clone();
        }

        [CLSCompliant(false)]
        public ulong[] Clone(
            ulong[] data,
            ulong[] existing)
        {
            if (data == null)
            {
                return null;
            }
            if ((existing == null) || (existing.Length != data.Length))
            {
                return Clone(data);
            }
            Array.Copy(data, 0, existing, 0, existing.Length);
            return existing;
        }

        public bool Contains(byte[] a, byte n)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == n)
                    return true;
            }
            return false;
        }

        public bool Contains(short[] a, short n)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == n)
                    return true;
            }
            return false;
        }

        public bool Contains(int[] a, int n)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == n)
                    return true;
            }
            return false;
        }

        public void Fill(
            byte[] buf,
            byte b)
        {
            int i = buf.Length;
            while (i > 0)
            {
                buf[--i] = b;
            }
        }

        public byte[] CopyOf(byte[] data, int newLength)
        {
            byte[] tmp = new byte[newLength];
            Array.Copy(data, 0, tmp, 0, System.Math.Min(newLength, data.Length));
            return tmp;
        }

        public char[] CopyOf(char[] data, int newLength)
        {
            char[] tmp = new char[newLength];
            Array.Copy(data, 0, tmp, 0, System.Math.Min(newLength, data.Length));
            return tmp;
        }

        public int[] CopyOf(int[] data, int newLength)
        {
            int[] tmp = new int[newLength];
            Array.Copy(data, 0, tmp, 0, System.Math.Min(newLength, data.Length));
            return tmp;
        }

        public long[] CopyOf(long[] data, int newLength)
        {
            long[] tmp = new long[newLength];
            Array.Copy(data, 0, tmp, 0, System.Math.Min(newLength, data.Length));
            return tmp;
        }


        /**
         * Make a copy of a range of bytes from the passed in data array. The range can
         * extend beyond the end of the input array, in which case the return array will
         * be padded with zeroes.
         *
         * @param data the array from which the data is to be copied.
         * @param from the start index at which the copying should take place.
         * @param to the final index of the range (exclusive).
         *
         * @return a new byte array containing the range given.
         */
        public byte[] CopyOfRange(byte[] data, int from, int to)
        {
            int newLength = GetLength(from, to);
            byte[] tmp = new byte[newLength];
            Array.Copy(data, from, tmp, 0, System.Math.Min(newLength, data.Length - from));
            return tmp;
        }

        public int[] CopyOfRange(int[] data, int from, int to)
        {
            int newLength = GetLength(from, to);
            int[] tmp = new int[newLength];
            Array.Copy(data, from, tmp, 0, System.Math.Min(newLength, data.Length - from));
            return tmp;
        }

        public long[] CopyOfRange(long[] data, int from, int to)
        {
            int newLength = GetLength(from, to);
            long[] tmp = new long[newLength];
            Array.Copy(data, from, tmp, 0, System.Math.Min(newLength, data.Length - from));
            return tmp;
        }

        private static int GetLength(int from, int to)
        {
            int newLength = to - from;
            if (newLength < 0)
                throw new ArgumentException(from + " > " + to);
            return newLength;
        }

        public byte[] Append(byte[] a, byte b)
        {
            if (a == null)
                return new byte[] { b };

            int length = a.Length;
            byte[] result = new byte[length + 1];
            Array.Copy(a, 0, result, 0, length);
            result[length] = b;
            return result;
        }

        public short[] Append(short[] a, short b)
        {
            if (a == null)
                return new short[] { b };

            int length = a.Length;
            short[] result = new short[length + 1];
            Array.Copy(a, 0, result, 0, length);
            result[length] = b;
            return result;
        }

        public int[] Append(int[] a, int b)
        {
            if (a == null)
                return new int[] { b };

            int length = a.Length;
            int[] result = new int[length + 1];
            Array.Copy(a, 0, result, 0, length);
            result[length] = b;
            return result;
        }

        public byte[] Concatenate(byte[] a, byte[] b)
        {
            if (a == null)
                return Clone(b);
            if (b == null)
                return Clone(a);

            byte[] rv = new byte[a.Length + b.Length];
            Array.Copy(a, 0, rv, 0, a.Length);
            Array.Copy(b, 0, rv, a.Length, b.Length);
            return rv;
        }

        public byte[] ConcatenateAll(params byte[][] vs)
        {
            byte[][] nonNull = new byte[vs.Length][];
            int count = 0;
            int totalLength = 0;

            for (int i = 0; i < vs.Length; ++i)
            {
                byte[] v = vs[i];
                if (v != null)
                {
                    nonNull[count++] = v;
                    totalLength += v.Length;
                }
            }

            byte[] result = new byte[totalLength];
            int pos = 0;

            for (int j = 0; j < count; ++j)
            {
                byte[] v = nonNull[j];
                Array.Copy(v, 0, result, pos, v.Length);
                pos += v.Length;
            }

            return result;
        }

        public int[] Concatenate(int[] a, int[] b)
        {
            if (a == null)
                return Clone(b);
            if (b == null)
                return Clone(a);

            int[] rv = new int[a.Length + b.Length];
            Array.Copy(a, 0, rv, 0, a.Length);
            Array.Copy(b, 0, rv, a.Length, b.Length);
            return rv;
        }

        public byte[] Prepend(byte[] a, byte b)
        {
            if (a == null)
                return new byte[] { b };

            int length = a.Length;
            byte[] result = new byte[length + 1];
            Array.Copy(a, 0, result, 1, length);
            result[0] = b;
            return result;
        }

        public short[] Prepend(short[] a, short b)
        {
            if (a == null)
                return new short[] { b };

            int length = a.Length;
            short[] result = new short[length + 1];
            Array.Copy(a, 0, result, 1, length);
            result[0] = b;
            return result;
        }

        public int[] Prepend(int[] a, int b)
        {
            if (a == null)
                return new int[] { b };

            int length = a.Length;
            int[] result = new int[length + 1];
            Array.Copy(a, 0, result, 1, length);
            result[0] = b;
            return result;
        }

        public byte[] Reverse(byte[] a)
        {
            if (a == null)
                return null;

            int p1 = 0, p2 = a.Length;
            byte[] result = new byte[p2];

            while (--p2 >= 0)
            {
                result[p2] = a[p1++];
            }

            return result;
        }

        public int[] Reverse(int[] a)
        {
            if (a == null)
                return null;

            int p1 = 0, p2 = a.Length;
            int[] result = new int[p2];

            while (--p2 >= 0)
            {
                result[p2] = a[p1++];
            }

            return result;
        }

        public byte[] ConvertToByteArray(uint[] inputInts)
        {
            var len = 4;
            byte[] byteArray = new byte[inputInts.Length * len];

            for (int i = 0; i < inputInts.Length; i++)
            {
                var bytes = BitConverter.GetBytes(inputInts[i]);
                if (!BitConverter.IsLittleEndian)
                    Array.Reverse(bytes);
                Array.Copy(bytes, 0, byteArray, i * len, len);

            }

            return byteArray;
        }

        public int[] ConvertToInt32Array(byte[] inputBytes)
        {
            var len = 4;
            int[] intArray = new int[inputBytes.Length / len];

            for (int i = 0; i < intArray.Length; i++)
            {
                var bytes = new byte[4];
                Array.Copy(inputBytes, i * len, bytes, 0, len);
                var value = ConvertToInt32(bytes);
                intArray[i] = value;
            }

            return intArray;
        }

        public int ConvertToInt32(byte[] bytes)
        {
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            int result = BitConverter.ToInt32(bytes, 0);
            return result;
        }
    }
}
