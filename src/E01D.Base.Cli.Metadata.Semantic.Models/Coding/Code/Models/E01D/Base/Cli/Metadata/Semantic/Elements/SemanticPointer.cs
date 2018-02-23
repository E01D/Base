using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;


namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticPointer:SemanticType, SemanticPointer_I
    {
        public override TypeKind TypeKind => TypeKind.Pointer;
    }
}
