using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models
{
    public class SemanticModel: MetadataModel, SemanticModel_I
    {
        public SemanticAssemblyModel Assemblies { get; set; } = new SemanticAssemblyModel();

        public Dictionary<long, SemanticAttribute> Attributes { get; set; } = new Dictionary<long, SemanticAttribute>();

        public Dictionary<long, SemanticDelegate> Delegates { get; set; } = new Dictionary<long, SemanticDelegate>();

        public Dictionary<long, SemanticEnum> Enums { get; set; } = new Dictionary<long, SemanticEnum>();

        public Dictionary<long, SemanticPointer> Pointers { get; set; } = new Dictionary<long, SemanticPointer>();

        public Dictionary<long, SemanticArray> Arrays { get; set; } = new Dictionary<long, SemanticArray>();

        public Dictionary<long, SemanticClass> Classes { get; set; } = new Dictionary<long, SemanticClass>();

        public Dictionary<long, SemanticInterface> Interfaces { get; set; } = new Dictionary<long, SemanticInterface>();

        public Dictionary<long, SemanticType_I> Types { get; set; } = new Dictionary<long, SemanticType_I>();

        public Dictionary<long, SemanticValueType> ValueTypes { get; set; } = new Dictionary<long, SemanticValueType>();

        


        
    }
}
