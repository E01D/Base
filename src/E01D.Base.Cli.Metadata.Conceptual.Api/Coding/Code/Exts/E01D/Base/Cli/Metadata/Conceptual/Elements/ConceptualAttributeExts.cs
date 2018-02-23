using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public static class ConceptualAttributeExts
    {
        public static RuntimeTypeHandle TypeHandle(this ConceptualAttribute_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Attributes.TypeHandle(type);
        }
    }
}
