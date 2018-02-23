using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.Transceiving.Transceivers
{
    public class UInt08Api
    {
        public void Write(Block_I block, byte data)
        {
            block.Data[block.Position++] = data;
        }

        public void Read(Block_I block, out byte data)
        {
            data = block.Data[block.Position++];
        }

        public void Write(Block_I block, byte[] data)
        {
            Write(block, data, data.LongLength);
        }

        public void Write(Block_I block, byte[] data, long length)
        {
            Write(block, data, 0, length);
        }

        public void Write(Block_I block, byte[] data, long offset, long length)
        {
            for (long i = 0; i < length; i++)
            {
                Write(block, data[offset + i]);
            }
        }

        public void Read(Block_I block, byte[] data)
        {
            Read(block, data, 0, data.Length);
        }

        public void Read(Block_I block, byte[] data, long length)
        {
            Read(block, data, 0, length);
        }

        public void Read(Block_I block, byte[] data, long offset, long length)
        {
            for (long i = 0; i < length; i++)
            {
                byte dataByte;

                Read(block, out dataByte);

                data[offset + i] = dataByte;
            }
        }

    }
}
