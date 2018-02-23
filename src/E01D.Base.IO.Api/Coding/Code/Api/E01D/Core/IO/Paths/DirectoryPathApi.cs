using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Core.IO.Paths
{
    public class DirectoryPathApi
    {
        public AbsoluteFilePath[] GetFiles(DirectoryPath directory)
        {
            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(directory.Value);

            var fileInfos = directoryInfo.GetFiles();

            AbsoluteFilePath[] files = new AbsoluteFilePath[fileInfos.Length];

            for (int i = 0; i < fileInfos.Length; i++)
            {
                files[i] = XIO.AbsoluteFilePath(fileInfos[i]);
            }

            return files;
        }
    }
}
