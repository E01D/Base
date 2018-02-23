using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Constants.E01D.Base.Primitives.Strings.Base64Encoding;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Base.Async;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings.Base64Encoding;
using Root.Coding.Code.Exts.E01D.Base.Primitives.Strings.Textual;

namespace Root.Coding.Code.Api.E01D.Base.Primitives.Strings
{
    public class Base64EncodingApi
    {
        public Base64Encoder New(TextWriter writer)
        {
            XValidation.ArgumentNotNull(writer, nameof(writer));

            Base64Encoder encoder = new Base64Encoder()
            {
                Writer = writer
            };

            return encoder;
        }

        private void ValidateEncode(Base64Encoder encoder, byte[] buffer, int index, int count)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (count > (buffer.Length - index))
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
        }

        public void Encode(Base64Encoder encoder, byte[] buffer, int index, int count)
        {
            ValidateEncode(encoder, buffer, index, count);

            if (encoder.LeftOverBytesCount > 0)
            {
                if (FulfillFromLeftover(encoder, buffer, index, ref count))
                {
                    return;
                }

                int num2 = Convert.ToBase64CharArray(encoder.LeftOverBytes, 0, 3, encoder.CharsLine, 0);
                WriteChars(encoder, encoder.CharsLine, 0, num2);
            }

            StoreLeftOverBytes(encoder, buffer, index, ref count);

            int num4 = index + count;
            int length = Base64CodecConstants.LineSizeInBytes;
            while (index < num4)
            {
                if ((index + length) > num4)
                {
                    length = num4 - index;
                }
                int num6 = Convert.ToBase64CharArray(buffer, index, length, encoder.CharsLine, 0);
                WriteChars(encoder, encoder.CharsLine, 0, num6);
                index += length;
            }
        }



        public void Flush(Base64Encoder encoder)
        {
            if (encoder.LeftOverBytesCount > 0)
            {
                int count = Convert.ToBase64CharArray(encoder.LeftOverBytes, 0, encoder.LeftOverBytesCount, encoder.CharsLine, 0);
                WriteChars(encoder, encoder.CharsLine, 0, count);
                encoder.LeftOverBytesCount = 0;
            }
        }

        private void StoreLeftOverBytes(Base64Encoder encoder, byte[] buffer, int index, ref int count)
        {
            int leftOverBytesCount = count % 3;
            if (leftOverBytesCount > 0)
            {
                count -= leftOverBytesCount;
                if (encoder.LeftOverBytes == null)
                {
                    encoder.LeftOverBytes = new byte[3];
                }

                for (int i = 0; i < leftOverBytesCount; i++)
                {
                    encoder.LeftOverBytes[i] = buffer[index + count + i];
                }
            }

            encoder.LeftOverBytesCount = leftOverBytesCount;
        }

        private bool FulfillFromLeftover(Base64Encoder encoder, byte[] buffer, int index, ref int count)
        {
            int leftOverBytesCount = encoder.LeftOverBytesCount;
            while (leftOverBytesCount < 3 && count > 0)
            {
                encoder.LeftOverBytes[leftOverBytesCount++] = buffer[index++];
                count--;
            }

            if (count == 0 && leftOverBytesCount < 3)
            {
                encoder.LeftOverBytesCount = leftOverBytesCount;
                return true;
            }

            return false;
        }

        private void WriteChars(Base64Encoder encoder, char[] chars, int index, int count)
        {
            encoder.Writer.Write(chars, index, count);
        }

        public async Task EncodeAsync(Base64Encoder encoder, byte[] buffer, int index, int count, CancellationToken cancellationToken)
        {
            ValidateEncode(encoder, buffer, index, count);

            if (encoder.LeftOverBytesCount > 0)
            {
                if (FulfillFromLeftover(encoder, buffer, index, ref count))
                {
                    return;
                }

                int num2 = Convert.ToBase64CharArray(encoder.LeftOverBytes, 0, 3, encoder.CharsLine, 0);
                await WriteCharsAsync(encoder, encoder.CharsLine, 0, num2, cancellationToken).ConfigureAwait(false);
            }

            StoreLeftOverBytes(encoder, buffer, index, ref count);

            int num4 = index + count;
            int length = Base64CodecConstants.LineSizeInBytes;
            while (index < num4)
            {
                if (index + length > num4)
                {
                    length = num4 - index;
                }
                int num6 = Convert.ToBase64CharArray(buffer, index, length, encoder.CharsLine, 0);
                await WriteCharsAsync(encoder, encoder.CharsLine, 0, num6, cancellationToken).ConfigureAwait(false);
                index += length;
            }
        }

        private Task WriteCharsAsync(Base64Encoder encoder, char[] chars, int index, int count, CancellationToken cancellationToken)
        {
            return encoder.Writer.WriteAsync(chars, index, count, cancellationToken);
        }

        public Task FlushAsync(Base64Encoder encoder, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return cancellationToken.FromCanceled();
            }

            if (encoder.LeftOverBytesCount > 0)
            {
                int count = Convert.ToBase64CharArray(encoder.LeftOverBytes, 0, encoder.LeftOverBytesCount, encoder.CharsLine, 0);
                encoder.LeftOverBytesCount = 0;
                return WriteCharsAsync(encoder, encoder.CharsLine, 0, count, cancellationToken);
            }

            return XAsync.CompletedTask;
        }

    }
}
