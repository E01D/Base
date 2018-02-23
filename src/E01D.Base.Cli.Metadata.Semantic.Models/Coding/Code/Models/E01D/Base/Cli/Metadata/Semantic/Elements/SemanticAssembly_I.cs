using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    /// <summary>
    /// Represents an assembly that is part of a semantic analysis
    /// </summary>
    public interface SemanticAssembly_I:SemanticGrouping_I
    {
        Dictionary<long, SemanticClass_I> Classes { get; set; }

        Dictionary<long, SemanticInterface_I> Interfaces { get; set; }

        Dictionary<long, SemanticType_I> Types { get; set; }
    }
}
