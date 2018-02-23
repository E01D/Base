using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class ArrayApi : TypeBaseApi<SemanticArray>
    {
        public override Dictionary<long, SemanticArray> GetModelStorage(SemanticModel_I model)
        {
            return model.Arrays;
        }

        public override SemanticArray CreateNewElement(SemanticModel_I model, Type type)
        {
            SemanticArray element = XNew.New<SemanticArray>();

           

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticArray element, Type type)
        {
            
        }
    }
}
