using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Root.Code.Exts.E01D.Core.IO;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal
{
    public class AssemblyApiBase
    {
        /// <summary>
        /// Gets whether the file is an dynamic link library based upon its file extension alone.
        /// </summary>
        /// <returns>Returns true if the file is an dynamic link library file, else it returns false</returns>
        public bool IsDll(AbsoluteFilePath filePath)
        {
            return ".dll".Equals(filePath.Filename.Extension, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets whether the file is an executable based upon its file extension alone.
        /// </summary>
        /// <returns>Returns true if the file is an executable file, else it returns false</returns>
        public bool IsExe(AbsoluteFilePath filePath)
        {
            return ".exe".Equals(filePath.Filename.Extension, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets all the files that are in a directory that are an assembly based upon their extension
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public List<AbsoluteFilePath> GetAssemblyFiles(DirectoryPath directory)
        {
            var result = new List<AbsoluteFilePath>();

            if (directory == null) return result;

            var files = directory.GetFiles();

            // ReSharper disable once ForCanBeConvertedToForeach
            // ReSharper disable once LoopCanBeConvertedToQuery
            for (var i = 0; i < files.Length; i++)
            {
                var file = files[i];

                if (IsDll(file) || IsExe(file))
                {
                    result.Add(file);
                }
            }

            return result;
        }

        public DirectoryPath GetEntryAssemblyLocalPath()
        {
            var entryAssembly = Assembly.GetEntryAssembly();

            if (entryAssembly == null) return null;

            var codeBase = entryAssembly.CodeBase;

            var localPath = new Uri(codeBase).LocalPath;

            var index = localPath.LastIndexOf('\\');

            localPath = localPath.Substring(0, index);

            return XIO.DirectoryPath(localPath);
        }

        public static string GetEmbeddedResourceText(Assembly assembly, string embeddedResourceName)
        {
            using (var stream = assembly.GetManifestResourceStream(embeddedResourceName))
            {
                if (stream == null)
                {
                    var message = $"The embedded resource '{embeddedResourceName}' could not be found in the assembly '{assembly.FullName}'.";

                    throw new ArgumentException(message);
                }

                using (var ms = new StreamReader(stream))
                {
                    return ms.ReadToEnd();
                }
            }
        }
    }
}
