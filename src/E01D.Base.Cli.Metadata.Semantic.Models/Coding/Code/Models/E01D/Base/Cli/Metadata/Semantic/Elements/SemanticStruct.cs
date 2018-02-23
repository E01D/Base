using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticStruct : SemanticReferenceOrValueType, SemanticStruct_I
    {
        public override TypeKind TypeKind => TypeKind.Struct;
    }
}
