using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticEnum:SemanticNamedType, SemanticEnum_I
    {
        public override TypeKind TypeKind => TypeKind.Enum;
    }
}
