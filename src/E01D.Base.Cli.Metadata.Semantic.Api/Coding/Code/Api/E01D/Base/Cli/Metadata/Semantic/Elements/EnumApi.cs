using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class EnumApi : TypeBaseApi<SemanticEnum>
    {
        public override Dictionary<long, SemanticEnum> GetModelStorage(SemanticModel_I model)
        {
            return model.Enums;
        }

        public override SemanticEnum CreateNewElement(SemanticModel_I model, Type type)
        {
            SemanticEnum element = XNew.New<SemanticEnum>();

            element.RuntimeMapping = type.TypeHandle;

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticEnum element, Type type)
        {
            
        }
    }
}
