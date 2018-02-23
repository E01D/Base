using System;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class ClassApi : TypeBaseApi<SemanticClass>
    {
        

        public override Dictionary<long, SemanticClass> GetModelStorage(SemanticModel_I model)
        {
            return model.Classes;
        }

        public override SemanticClass CreateNewElement(SemanticModel_I model, Type type)
        {
            
            SemanticClass element;

            // if it is an attribute then we want to create an attribute class, that can hold more information about what types implement the attribute.
            if (XTypes.IsAttribute(type))
            {
                // already know it does not exist in the model as it is being called from a get or create statement (at initial version)
                SemanticAttributeClass attributeClass = XNew.New<SemanticAttributeClass>();

                element = attributeClass;
            }
            else
            {
                element = XNew.New<SemanticClass>();
            }

            element.RuntimeMapping = type.TypeHandle;

            return element;
        }

        public override void OnCreateElement(SemanticModel_I semanticModel, SemanticClass element, Type type)
        {
            
        }
    }
}
