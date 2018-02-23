using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.IO.Scanning;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Types.Scanning;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal.Scanning;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XReflectionScanning
    {
        public static ScanningApi Api { get; set; } = new ScanningApi();

        public static IOScanningApi IO => Api.IO;

        public static TypeScanningApi Types => Api.Types;

        public static AssemblyScanningApi Assemblies => Api.Assemblies;



    }
}
