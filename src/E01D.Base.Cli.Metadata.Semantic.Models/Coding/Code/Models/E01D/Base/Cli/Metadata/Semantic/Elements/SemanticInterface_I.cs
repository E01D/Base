using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    /// <summary>
    /// Represents an interface used in semantic analysis
    /// </summary>
    public interface SemanticInterface_I: SemanticReferenceOrValueType_I, ConceptualInterface_I
    {
        Dictionary<long, SemanticType_I> ImplementingTypes { get; set; }

        Dictionary<long, SemanticClass_I> ImplementingClasses { get; set; }
    }
}
