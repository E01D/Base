using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public class ConceptualMethodApi: ConceptualMemberVisbilityBaseApi
    {
        /// <summary>
        /// Gets whether the method is marked as abstract.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsAbstract(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAbstract(method);
        }

        /// <summary>
        /// Gets whether the method is marked as async.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsAsync(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsAsync(method);
        }

        /// <summary>
        /// Gets whether the method is marked as extern.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsExtern(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsExtern(method);
        }

        /// <summary>
        /// Gets whether the method is marked as new.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsNew(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsNew(method);
        }

        /// <summary>
        /// Gets whether the method is marked as overridden.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsOverride(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsOverride(method);
        }

        /// <summary>
        /// Gets whether the method is marked as static.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsStatic(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsStatic(method);
        }

        /// <summary>
        /// Gets whether the method is marked as unsafe.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsUnsafe(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsUnsafe(method);
        }

        /// <summary>
        /// Gets whether the method is marked as virtual.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool IsVirtual(ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Metadata.IsVirtual(method);
        }
    }
}
