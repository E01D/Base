using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class PointerApi : TypeBaseApi<SemanticPointer>
    {
        public override Dictionary<long, SemanticPointer> GetModelStorage(SemanticModel_I model)
        {
            return model.Pointers;
        }

        public override SemanticPointer CreateNewElement(SemanticModel_I model, Type type)
        {
            SemanticPointer element = XNew.New<SemanticPointer>();

            element.RuntimeMapping = type.TypeHandle;

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticPointer element, Type type)
        {
            
        }
    }
}
