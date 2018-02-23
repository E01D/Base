using System.Collections.Generic;
using Root.Code.Domain.E01D;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class BlockFileApi
    {
        public Block_I IssueBlock(BlockFile_I file, int size)
        {
            var block = XIO.Api.Blocks.CreateBlock(size);

            block.Address = file.Length;

            file.Length += block.Length;

            file.Blocks.Add(block);

            return block;
        }

        public Block_I ObtainFreeBlock(int size)
        {
            throw new System.NotImplementedException();
        }

        public void WriteToStream(BlockFile_I file, System.IO.Stream stream)
        {
            var blocksSorted = SortBlocks(file);

            for (var i = 0; i < blocksSorted.Count; i++)
            {
                var block = blocksSorted[i];

                XIO.Api.Blocks.WriteToStream(block, stream);
            }
        }

        private List<Block_I> SortBlocks(BlockFile_I file)
        {
            var copy = new List<Block_I>(file.Blocks.Count);

            for (var i = 0; i < file.Blocks.Count; i++)
            {
                copy.Add(file.Blocks[i]);
            }

            XSorting.Api.Quicksort.Sort(copy, (x, y) => x.Address - y.Address);

            return copy;
        }
    }
}
