using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualPropertyApi: ConceptualMemberVisbilityBaseApi
    {
        /// <summary>
        /// Gets whether the property is marked as abstract.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool IsAbstract(ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAbstract(property);
        }

        /// <summary>
        /// Gets whether the property is marked as new.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool IsNew(ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsNew(property);
        }

        /// <summary>
        /// Gets whether the property is marked as overridden.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool IsOverride(ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsOverride(property);
        }

        /// <summary>
        /// Gets whether the property is marked as static.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool IsStatic(ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsStatic(property);
        }

        /// <summary>
        /// Gets whether the property is marked as unsafe.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool IsUnsafe(ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsUnsafe(property);
        }

        /// <summary>
        /// Gets whether the property is marked as virtual.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool IsVirtual(ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsVirtual(property);
        }
    }
}
