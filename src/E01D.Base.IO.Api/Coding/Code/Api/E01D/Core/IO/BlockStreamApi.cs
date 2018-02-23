using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class BlockStreamApi
    {

        public void Buffer(BlockStream_I stream, int length)
        {
            Buffer(stream, stream.Stream.Position, length);
        }

        public void Buffer(BlockStream_I stream, long position, int length)
        {
            long tempPosition = stream.Stream.Position;

            stream.Stream.Position = position;

            stream.Stream.Read(stream.Block.Data, 0, length);

            stream.Block.Position = 0;

            stream.Stream.Position = tempPosition;
        }


        public Block IssueBlock(BlockFileStream stream, int length)
        {
            var block = new Block
            {
                Address = stream.NextAddressToIssue,
                Position = 0,
                Length = length,
                Data = new byte[length]
            };

            stream.NextAddressToIssue += length;

            var node = new BlockNode
            {
                Value = block,
                Key = block.Address
            };

            //stream.BlockTree = XIO.Api.BlockNodes.AddNode(stream.BlockTree, node);

            return block;
        }

        public void ReadAsciiChars(BlockStream_I blockStream, int length)
        {
            
        }
    }
}
