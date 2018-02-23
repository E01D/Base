using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic
{
    public class ModelApi
    {
        //public bool GetTypeHandle(SemanticModel_I model, long id, out RuntimeTypeHandle typeHandle)
        //{
        //    if (model?.TypeHandles != null) return model.TypeHandles.TryGetValue(id, out typeHandle);

        //    typeHandle = default(RuntimeTypeHandle);

        //    return false;
        //}

        //public bool GetId(SemanticModel_I model, RuntimeTypeHandle typeHandle, out TypeId_I id)
        //{
        //    if (model?.TypeHandles != null) return model.TypeIdsByTypeHandle.TryGetValue(typeHandle, out id);

        //    id = 0;

        //    return false;
        //}

        public SemanticType_I GetOrCreateElement(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.GetOrCreateElement(model, type);
        }

        public SemanticClass_I GetOrCreateClass(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.Classes.GetOrCreateElement(model, type);
        }

        public SemanticInterface_I GetOrCreateInterface(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.Interfaces.GetOrCreateElement(model, type);
        }

        public SemanticEnum_I GetOrCreateEnum(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.Enums.GetOrCreateElement(model, type);
        }

        public SemanticValueType_I GetOrCreateValueType(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.ValueTypes.GetOrCreateElement(model, type);
        }

        public SemanticDelegate_I GetOrCreateDelegate(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.Delegates.GetOrCreateElement(model, type);
        }

        public SemanticArray_I GetOrCreateArray(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.Arrays.GetOrCreateElement(model, type);
        }

        public SemanticPointer_I GetOrCreatePointer(SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.Pointers.GetOrCreateElement(model, type);
        }
    }
}
