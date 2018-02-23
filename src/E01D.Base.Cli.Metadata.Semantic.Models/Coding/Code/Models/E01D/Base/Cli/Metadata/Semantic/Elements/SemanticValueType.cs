using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticValueType:SemanticNamedType, SemanticValueType_I
    {
        public override TypeKind TypeKind => TypeKind.Struct;

    }

    
}
