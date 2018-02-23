using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Semantic
{
    public static class ModelExts
    {
        //public static bool GetTypeHandle(this SemanticModel_I model, long id, out RuntimeTypeHandle typeHandle)
        //{
        //    return XSemanticMetadata.Api.Models.GetTypeHandle(model, id, out typeHandle);
        //}

        //public static bool GetTypeId(this SemanticModel_I model, RuntimeTypeHandle typeHandle, out TypeId_I id)
        //{
        //    return XSemanticMetadata.Api.Models.GetId(model, typeHandle, out id);
        //}

        public static SemanticType_I GetOrCreateElement(this SemanticModel_I model, Type type)
        {
            return XSemanticMetadata.Api.Elements.GetOrCreateElement(model, type);
        }
    }
}
