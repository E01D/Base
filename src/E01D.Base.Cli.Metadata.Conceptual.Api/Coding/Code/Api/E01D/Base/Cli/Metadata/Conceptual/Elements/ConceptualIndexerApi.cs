using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualIndexerApi: ConceptualMemberVisbilityBaseApi
    {
        /// <summary>
        /// Gets whether the indexer is marked as abstract.
        /// </summary>
        /// <param name="indexer"></param>
        /// <returns></returns>
        public bool IsAbstract(ConceptualIndexer_I indexer)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAbstract(indexer);
        }

        /// <summary>
        /// Gets whether the indexer is marked as new.
        /// </summary>
        /// <param name="indexer"></param>
        /// <returns></returns>
        public bool IsNew(ConceptualIndexer_I indexer)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsNew(indexer);
        }

        /// <summary>
        /// Gets whether the indexer is marked as overridden.
        /// </summary>
        /// <param name="indexer"></param>
        /// <returns></returns>
        public bool IsOverride(ConceptualIndexer_I indexer)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsOverride(indexer);
        }

        /// <summary>
        /// Gets whether the indexer is marked as static.
        /// </summary>
        /// <param name="indexer"></param>
        /// <returns></returns>
        public bool IsStatic(ConceptualIndexer_I indexer)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsStatic(indexer);
        }

        /// <summary>
        /// Gets whether the indexer is marked as unsafe.
        /// </summary>
        /// <param name="indexer"></param>
        /// <returns></returns>
        public bool IsUnsafe(ConceptualIndexer_I indexer)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsUnsafe(indexer);
        }

        /// <summary>
        /// Gets whether the indexer is marked as virtual.
        /// </summary>
        /// <param name="indexer"></param>
        /// <returns></returns>
        public bool IsVirtual(ConceptualIndexer_I indexer)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsVirtual(indexer);
        }
    }
}
