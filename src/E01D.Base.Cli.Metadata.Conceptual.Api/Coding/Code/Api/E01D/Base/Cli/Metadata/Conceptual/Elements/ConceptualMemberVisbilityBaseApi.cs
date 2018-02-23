using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public abstract class ConceptualMemberVisbilityBaseApi
    {
        public bool IsPublic(ConceptualMember_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAbstract(member);
        }

        public bool IsPrivate(ConceptualMember_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAsync(member);
        }

        public bool IsInternal(ConceptualMember_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsExtern(member);
        }

        public bool IsProtected(ConceptualMember_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsNew(member);
        }
    }
}
