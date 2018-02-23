using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public static class ConceptualPropertyExts
    {
        /// <summary>
        /// Gets whether the property is marked as abstract.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsAbstract(this ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsAbstract(property);
        }

        /// <summary>
        /// Gets whether the property is marked as new.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsNew(this ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsNew(property);
        }

        /// <summary>
        /// Gets whether the property is marked as overridden.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsOverride(this ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsOverride(property);
        }

        /// <summary>
        /// Gets whether the property is marked as static.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsStatic(this ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsStatic(property);
        }

        /// <summary>
        /// Gets whether the property is marked as unsafe.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsUnsafe(this ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsUnsafe(property);
        }

        /// <summary>
        /// Gets whether the property is marked as virtual.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsVirtual(this ConceptualProperty_I property)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsVirtual(property);
        }

        /// <summary>
        /// Gets whether the property is marked as public
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPublic(ConceptualProperty_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsPublic(member);
        }

        /// <summary>
        /// Gets whether the property is marked as private
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPrivate(ConceptualProperty_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsPrivate(member);
        }

        /// <summary>
        /// Gets whether the property is marked as internal
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsInternal(ConceptualProperty_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsInternal(member);
        }

        /// <summary>
        /// Gets whether the property is marked as protected
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsProtected(ConceptualProperty_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Properties.IsProtected(member);
        }
    }
}
