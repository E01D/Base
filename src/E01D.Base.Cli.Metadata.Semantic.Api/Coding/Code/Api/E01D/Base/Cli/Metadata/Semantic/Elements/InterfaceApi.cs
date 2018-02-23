using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class InterfaceApi : TypeBaseApi<SemanticInterface>
    {
        public override Dictionary<long, SemanticInterface> GetModelStorage(SemanticModel_I model)
        {
            return model.Interfaces;
        }

        public override SemanticInterface CreateNewElement(SemanticModel_I model, Type type)
        {
            SemanticInterface element = XNew.New<SemanticInterface>();

            element.RuntimeMapping = type.TypeHandle;

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticInterface element, Type type)
        {
            
        }
    }
}
