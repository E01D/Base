using System.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal.Scanning
{
    public class AssemblyScanningApi
    {
        public void ScanAssembly(SemanticModel library, Assembly assembly)
        {
            var types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                XTypeScanning.Api.ScanType(library, types[i]);
            }
        }
    }
}
