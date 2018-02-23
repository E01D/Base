using System.IO;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class BlockApi
    {
        public Block CreateBlock()
        {
            return CreateBlock(64);
        }

        public Block CreateBlock(int size)
        {
            return new Block
            {
                Data = new byte[size],
                Length = size
            };
        }

        public BlockStream_I CreateBlockStream(Stream stream)
        {
            return CreateBlockStream(stream, 256);
        }

        public BlockStream_I CreateBlockStream(Stream stream, int blockSize)
        {
            var block = CreateBlock(blockSize);

            return new BlockStream()
            {
                Stream = stream,
                Block = block
            };
        }

        public BlockStream_I CreateBlockStream(int blockSize)
        {
            return CreateBlockStream(null, blockSize);
        }

        public void WriteToStream(Block_I block, Stream stream)
        {
            stream.Write(block.Data, 0, block.Length);
        }

        public void WriteToStream(Block_I block, Stream stream, int length)
        {
            stream.Write(block.Data, 0, length);
        }

        public void WriteToStream(Block_I block, Stream stream, int offset, int length)
        {
            stream.Write(block.Data, offset, length);
        }
    }
}
