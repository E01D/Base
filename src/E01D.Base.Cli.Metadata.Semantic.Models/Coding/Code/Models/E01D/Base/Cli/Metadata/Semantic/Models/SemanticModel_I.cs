using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models
{
    public interface SemanticModel_I
    {
        Dictionary<long, SemanticAttribute> Attributes { get;  }

        Dictionary<long, SemanticDelegate> Delegates { get; }

        Dictionary<long, SemanticEnum> Enums { get; }

        Dictionary<long, SemanticPointer> Pointers { get; }

        Dictionary<long, SemanticArray> Arrays { get; }

        Dictionary<long, SemanticClass> Classes { get;  } 

        Dictionary<long, SemanticInterface> Interfaces { get;  } 

        Dictionary<long, SemanticType_I> Types { get;  } 

        
        Dictionary<long, SemanticValueType> ValueTypes { get; }
    }
}
