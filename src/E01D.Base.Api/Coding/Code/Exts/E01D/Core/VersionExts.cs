using Root.Coding.Code.Domains.E01D.Core;
using Root.Coding.Code.Models.E01D.Base;

namespace Root.Coding.Code.Exts.E01D.Core
{
    public static class VersionExts
    {
        public static int GetHash(this Version version)
        {
            return XBase.Api.Versions.GetHash(version);
        }
    }
}
