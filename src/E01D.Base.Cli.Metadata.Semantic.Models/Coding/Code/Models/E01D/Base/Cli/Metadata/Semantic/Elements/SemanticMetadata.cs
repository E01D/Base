using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public abstract class SemanticMetadata:MetadataBase, SemanticMetadata_I
    {
        public MetadataModifier MetadataModifiers { get; set; }
        public abstract bool IsMember { get; }
    }
}
