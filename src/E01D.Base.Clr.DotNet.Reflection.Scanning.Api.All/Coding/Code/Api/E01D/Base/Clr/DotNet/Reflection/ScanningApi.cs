using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.IO.Scanning;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Types.Scanning;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal.Scanning;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal
{
    public class ScanningApi
    {
        

        public AssemblyScanningApi Assemblies => XAssemblyScanning.Api;

        public IOScanningApi IO => XIOScanning.Api;

        public TypeScanningApi Types => XTypeScanning.Api;

        
    }
}
