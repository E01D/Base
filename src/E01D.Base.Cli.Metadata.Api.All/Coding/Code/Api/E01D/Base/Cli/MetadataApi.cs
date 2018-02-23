using Root.Coding.Code.Api.E01D.Base.Cli.Metadata;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Cli
{
    public class MetadataApi
    {
        public PhysicalMetadataApi Physical => XPhysicalMetdata.Api;
    }
}
