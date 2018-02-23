using System;
using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;
using Root.Coding.Code.Models.E01D.Base.Clr.Reflection.Typal.Contexts;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.IO.Scanning
{
    public class IOScanningApi
    {
        /// <summary>
        /// Scans a directory for assemblies and populate the results in the typal library.
        /// </summary>
        /// <param name="library"></param>
        /// <param name="directory"></param>
        public void ScanDirectoryForAssemblies(SemanticModel library, DirectoryPath directory)
        {
            var assemblyFiles = XAssemblies.GetAssemblyFiles(directory);

            foreach (var assemblyFile in assemblyFiles)
            {
                System.Reflection.Assembly assembly;



                try
                {
                    assembly = System.Reflection.Assembly.LoadFile(assemblyFile.Value);
                }
                catch (Exception e)
                {
                    assembly = null;

                    XLog.LogException(e);
                }

                if (assembly != null)
                {
                    XAssemblyScanning.Api.ScanAssembly(library, assembly);
                }
            }
        }

        public void ScanEntryAssemblyDirectoryForAssemblies()
        {
            TypalGlobalContext_I typal = XContextual.GetGlobal<TypalGlobalContext_I>();

            if (typal == null) return;
            
            // Need to build a semantic model of what is currently present.
            ScanEntryAssemblyDirectoryForAssemblies(typal.Library.SemanticModel);
            

        }

        /// <summary>
        /// Scans the directory containing the entry assembly for assemblies and populate the results in the typal library.
        /// </summary>
        public void ScanEntryAssemblyDirectoryForAssemblies(SemanticModel library)
        {
            var directory = XAssemblies.GetEntryAssemblyLocalPath();

            ScanDirectoryForAssemblies(library, directory);
        }
    }
}
