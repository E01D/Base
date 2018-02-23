using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Exts.E01D.Core.IO
{
    public static class FilepathExts
    {
        public static bool Exists(this AbsoluteFilePath path)

        {
            return XIO.FileExists(path);
        }
    }
}
