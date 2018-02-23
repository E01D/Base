using System.Reflection;
using Root.Code.Exts.E01D.IO;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Api.E01D.Core.Transceiving.IO
{
    public class BlockStreamApi
    {
        public void Write(BlockFileStream stream, object objectToWrite)
        {

        }

        public void Write(BlockFileStream stream, object objectToWrite, TypeInfo typeInfo)
        {

        }

        public Block Write(BlockFileStream stream, string stringToWrite)
        {
            var block = XIO.Api.BlockStreams.IssueBlock(stream, stringToWrite.Length * 2 + 8);

            block.Write(stringToWrite);

            return block;
        }
    }
}
