using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualTypeApi
    {
        public RuntimeTypeHandle TypeHandle(ConceptualType_I type)
        {
            return XMetadataBase.Api.TypeHandle(type);
        }

        
        public bool IsClass(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Class;
        }

        public bool IsInterface(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Interface;
        }

        public bool IsDelegate(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Delegate;
        }

        public bool IsStruct(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Struct;
        }

        public bool IsEnum(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Enum;
        }

        public bool IsPointer(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Pointer;
        }

        public bool IsArray( ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.Array;
        }

        public bool IsTypeParameter(ConceptualType_I type)
        {
            return type.TypeKind == Models.E01D.Base.Cli.Metadata.Conceptual.TypeKind.TypeParameter;
        }
    }
}
