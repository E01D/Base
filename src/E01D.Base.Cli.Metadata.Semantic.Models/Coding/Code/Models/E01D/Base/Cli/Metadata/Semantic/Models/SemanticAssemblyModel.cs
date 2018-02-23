using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models
{
    public class SemanticAssemblyModel
    {
        public Dictionary<string, SemanticAssembly> ByName { get; set; } = new Dictionary<string, SemanticAssembly>();

        public Dictionary<long, SemanticAssembly> ById { get; set; } = new Dictionary<long, SemanticAssembly>();
    }
}
