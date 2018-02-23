using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualFieldApi: ConceptualMemberVisbilityBaseApi
    {
        /// <summary>
        /// Gets whether the field is marked as abstract.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool IsAbstract(ConceptualField_I field)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAbstract(field);
        }

        /// <summary>
        /// Gets whether the field is marked as new.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool IsNew(ConceptualField_I field)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsNew(field);
        }

        /// <summary>
        /// Gets whether the field is marked as overridden.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool IsOverride(ConceptualField_I field)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsOverride(field);
        }

        /// <summary>
        /// Gets whether the field is marked as static.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool IsStatic(ConceptualField_I field)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsStatic(field);
        }

        /// <summary>
        /// Gets whether the field is marked as unsafe.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool IsUnsafe(ConceptualField_I field)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsUnsafe(field);
        }

        /// <summary>
        /// Gets whether the field is marked as virtual.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public bool IsVirtual(ConceptualField_I field)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsVirtual(field);
        }
    }
}
