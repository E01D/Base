using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    /// <summary>
    /// Represents an interface used in semantic analysis
    /// </summary>
    public class SemanticInterface: SemanticReferenceOrValueType, SemanticInterface_I
    {
        public Dictionary<long, SemanticType_I> ImplementingTypes { get; set; } = new Dictionary<long, SemanticType_I>();

        public Dictionary<long, SemanticClass_I> ImplementingClasses { get; set; } = new Dictionary<long, SemanticClass_I>();

        public override TypeKind TypeKind => TypeKind.Interface;
    }
}
