using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal.Scanning;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection
{
    public class AssemblyApi
    {
        public AssemblyScanningApi Scanning => XAssemblyScanning.Api;

        /// <summary>
        /// Gets whether the file is an dynamic link library based upon its file extension alone.
        /// </summary>
        /// <returns>Returns true if the file is an dynamic link library file, else it returns false</returns>
        public bool IsDll(AbsoluteFilePath filePath)
        {
            return XAssembliesBase.IsDll(filePath);
        }

        /// <summary>
        /// Gets whether the file is an executable based upon its file extension alone.
        /// </summary>
        /// <returns>Returns true if the file is an executable file, else it returns false</returns>
        public bool IsExe(AbsoluteFilePath filePath)
        {
            return XAssembliesBase.IsExe(filePath);
        }

        /// <summary>
        /// Gets all the files that are in a directory that are an assembly based upon their extension
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public List<AbsoluteFilePath> GetAssemblyFiles(DirectoryPath directory)
        {
            return XAssembliesBase.GetAssemblyFiles(directory);
        }

        public DirectoryPath GetEntryAssemblyLocalPath()
        {
            return XAssembliesBase.GetEntryAssemblyLocalPath();
        }
    }
}
