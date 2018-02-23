using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public abstract class SemanticType:SemanticNamespaceOrType, SemanticType_I, ConceptualType_I
    {
        public abstract TypeKind TypeKind { get; }

        
    }
}
