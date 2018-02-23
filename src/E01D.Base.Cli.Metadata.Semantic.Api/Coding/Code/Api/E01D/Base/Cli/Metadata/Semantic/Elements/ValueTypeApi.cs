using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class ValueTypeApi : TypeBaseApi<SemanticValueType>
    {
        public override Dictionary<long, SemanticValueType> GetModelStorage(SemanticModel_I model)
        {
            return model.ValueTypes;
        }

        public override SemanticValueType CreateNewElement(SemanticModel_I model, Type type)
        {
            SemanticValueType element = XNew.New<SemanticValueType>();

            element.RuntimeMapping = type.TypeHandle;

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticValueType element, Type type)
        {
            
        }
    }
}
