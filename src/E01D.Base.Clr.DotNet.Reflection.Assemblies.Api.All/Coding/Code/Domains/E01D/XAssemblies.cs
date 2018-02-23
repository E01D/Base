using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XAssemblies
    {
        public static AssemblyApi Api { get; set; } = new AssemblyApi();

        /// <summary>
        /// Gets whether the file is an dynamic link library based upon its file extension alone.
        /// </summary>
        /// <returns>Returns true if the file is an dynamic link library file, else it returns false</returns>
        public static bool IsDll(AbsoluteFilePath filePath)
        {
            return Api.IsDll(filePath);
        }

        /// <summary>
        /// Gets whether the file is an executable based upon its file extension alone.
        /// </summary>
        /// <returns>Returns true if the file is an executable file, else it returns false</returns>
        public static bool IsExe(AbsoluteFilePath filePath)
        {
            return Api.IsExe(filePath);
        }

        /// <summary>
        /// Gets all the files that are in a directory that are an assembly based upon their extension
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static List<AbsoluteFilePath> GetAssemblyFiles(DirectoryPath directory)
        {
            return Api.GetAssemblyFiles(directory);
        }

        public static DirectoryPath GetEntryAssemblyLocalPath()
        {
            return Api.GetEntryAssemblyLocalPath();
        }
    }
}
