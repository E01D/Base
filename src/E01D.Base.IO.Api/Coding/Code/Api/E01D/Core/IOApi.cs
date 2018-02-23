using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Core
{
    public class IOApi
    {
        public BlockNodeApi BlockNodes { get; set; } = new BlockNodeApi();

        public BlockApi Blocks { get; set; } = new BlockApi();

        public BlockStreamApi BlockStreams { get; set; } = new BlockStreamApi();

        public ByteApi Bytes { get; set; } = new ByteApi();

        public FileApi Files { get; set; } = new FileApi();

        public FlagsApi Flags { get; set; } = new FlagsApi();

        public PathApi Paths { get; set; } = new PathApi();
        


        public AbsoluteFilePath Combine(DirectoryPath solutionPath, RelativeFilePath projectRelativePath)
        {
            return Paths.Combine(solutionPath, projectRelativePath);
        }

        public void CopyFileToDirectory(string filenameString, string workingDirectory, bool replace)
        {
            var filePath = XIO.AbsoluteFilePath(filenameString);
            var directoryPath = XIO.DirectoryPath(workingDirectory);

           

            var destinationFilePath = Combine(directoryPath, XIO.RelativeFilePath(filePath.Filename.Value));

            System.IO.File.Copy(filePath.Value, destinationFilePath.Value, replace);
        }

        
    }
}
