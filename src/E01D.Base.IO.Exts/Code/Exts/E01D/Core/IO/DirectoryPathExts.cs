using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Exts.E01D.Core.IO
{
    public static class DirectoryPathExts
    {
        public static AbsoluteFilePath[] GetFiles(this DirectoryPath directory)
        {
            return XIO.Api.Paths.Directories.GetFiles(directory);
        }
    }
}
