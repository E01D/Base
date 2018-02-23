using Root.Coding.Code.Api.E01D.Base.Cli;
using Root.Coding.Code.Api.E01D.Base.Cli.Metadata;

namespace Root.Coding.Code.Domains.E01D
{
    public class XMetadata
    {
        public MetadataApi Api { get; set; } = new MetadataApi();

        public PhysicalMetadataApi Physical => XPhysicalMetdata.Api;

        public PhysicalMetadataApi Definitions => XPhysicalMetdata.Api;

        /// <summary>
        /// Gets the api responsible for manipulating metadata symbols
        /// </summary>
        //public SymbolMetadataApi Symbols => XSymbolMetdata.Api;

        /// <summary>
        /// Gets the api responsible for manipulating semantic metadata models.
        /// </summary>
        public PhysicalMetadataApi Semantic => XPhysicalMetdata.Api;

        public PhysicalMetadataApi Structural => XPhysicalMetdata.Api;

        
    }
}
