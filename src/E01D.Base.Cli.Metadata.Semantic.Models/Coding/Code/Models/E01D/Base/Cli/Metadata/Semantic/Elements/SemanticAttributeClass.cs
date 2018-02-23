using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticAttributeClass:SemanticClass
    {
        public Dictionary<long, SemanticType_I> ImplementingTypes { get; set; } = new Dictionary<long, SemanticType_I>();

        public Dictionary<long, SemanticClass_I> ImplementingClasses { get; set; } = new Dictionary<long, SemanticClass_I>();

        public Dictionary<long, SemanticInterface_I> ImplementingInterfaces { get; set; } = new Dictionary<long, SemanticInterface_I>();
        public List<SemanticAttributeTypeMapping> Instances { get; set; } = new List<SemanticAttributeTypeMapping>();
    }
}
