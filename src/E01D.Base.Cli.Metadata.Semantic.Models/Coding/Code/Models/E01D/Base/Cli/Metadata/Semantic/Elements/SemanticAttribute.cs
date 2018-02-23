using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticAttribute:SemanticMetadata, SemanticAttribute_I
    {
        

        public RuntimeTypeHandle TypeHandle { get; set; }

        public override bool IsMember => false;
    }
}
