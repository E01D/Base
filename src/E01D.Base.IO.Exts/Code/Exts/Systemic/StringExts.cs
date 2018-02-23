using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Exts.Systemic
{
    public static class StringExts
    {
        public static bool FileExistsInFolder(this DirectoryPath pathToFolder, Filename fileName)
        {
            return XIO.Api.Paths.FileExists(pathToFolder, fileName);
        }

        public static void AssertFileExists(this AbsoluteFilePath absoluteFilePath)
        {
            XIO.Api.Paths.AssertFileExists(absoluteFilePath);
        }

    }
}
