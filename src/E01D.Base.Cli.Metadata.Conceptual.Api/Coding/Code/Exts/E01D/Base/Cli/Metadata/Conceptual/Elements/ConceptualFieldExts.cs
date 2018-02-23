using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public static class ConceptualFieldExts
    {
        

        /// <summary>
        /// Gets whether the event is marked as static.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsStatic(this ConceptualField_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Fields.IsStatic(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as unsafe.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsUnsafe(this ConceptualField_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Fields.IsUnsafe(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as public
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPublic(ConceptualField_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Fields.IsPublic(member);
        }

        /// <summary>
        /// Gets whether the event is marked as private
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPrivate(ConceptualField_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Fields.IsPrivate(member);
        }

        /// <summary>
        /// Gets whether the event is marked as internal
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsInternal(ConceptualField_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Fields.IsInternal(member);
        }

        /// <summary>
        /// Gets whether the event is marked as protected
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsProtected(ConceptualField_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Fields.IsProtected(member);
        }
    }
}
