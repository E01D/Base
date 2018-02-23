using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualAttributeApi
    {
        public RuntimeTypeHandle TypeHandle(ConceptualAttribute_I type)
        {
            return XMetadataBase.Api.TypeHandle(type);
        }
    }
}
