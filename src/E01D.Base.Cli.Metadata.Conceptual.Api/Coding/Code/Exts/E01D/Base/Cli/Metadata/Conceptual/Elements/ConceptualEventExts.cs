using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public static class ConceptualEventExts
    {
        /// <summary>
        /// Gets whether the event is marked as abstract.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsAbstract(this ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsAbstract(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as new.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsNew(this ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsNew(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as overridden.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsOverride(this ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsOverride(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as static.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsStatic(this ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsStatic(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as unsafe.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsUnsafe(this ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsUnsafe(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as virtual.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static bool IsVirtual(this ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsVirtual(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as public
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPublic(ConceptualEvent_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsPublic(member);
        }

        /// <summary>
        /// Gets whether the event is marked as private
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPrivate(ConceptualEvent_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsPrivate(member);
        }

        /// <summary>
        /// Gets whether the event is marked as internal
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsInternal(ConceptualEvent_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsInternal(member);
        }

        /// <summary>
        /// Gets whether the event is marked as protected
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsProtected(ConceptualEvent_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Events.IsProtected(member);
        }
    }
}
