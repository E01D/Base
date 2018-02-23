using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualEventApi: ConceptualMemberVisbilityBaseApi
    {
        /// <summary>
        /// Gets whether the event is marked as abstract.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool IsAbstract(ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAbstract(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as new.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool IsNew(ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsNew(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as overridden.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool IsOverride(ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsOverride(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as static.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool IsStatic(ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsStatic(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as unsafe.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool IsUnsafe(ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsUnsafe(@event);
        }

        /// <summary>
        /// Gets whether the event is marked as virtual.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public bool IsVirtual(ConceptualEvent_I @event)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsVirtual(@event);
        }
    }
}
