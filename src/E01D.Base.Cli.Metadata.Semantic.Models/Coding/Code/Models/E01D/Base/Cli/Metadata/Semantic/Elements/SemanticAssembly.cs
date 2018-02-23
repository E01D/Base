using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticAssembly: SemanticGrouping, SemanticAssembly_I
    {
        

        public Dictionary<long, SemanticClass_I> Classes { get; set; } = new Dictionary<long, SemanticClass_I>();

        public Dictionary<long, SemanticInterface_I> Interfaces { get; set; } = new Dictionary<long, SemanticInterface_I>();

        public Dictionary<long, SemanticType_I> Types { get; set; } = new Dictionary<long, SemanticType_I>();
    }
}
