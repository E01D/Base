using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class DelegateApi : TypeBaseApi<SemanticDelegate>
    {
        public override Dictionary<long, SemanticDelegate> GetModelStorage(SemanticModel_I model)
        {
            return model.Delegates;
        }

        public override SemanticDelegate CreateNewElement(SemanticModel_I model, Type type)
        {
            SemanticDelegate element = XNew.New<SemanticDelegate>();

            element.RuntimeMapping = type.TypeHandle;

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticDelegate element, Type type)
        {
            
        }
    }
}
