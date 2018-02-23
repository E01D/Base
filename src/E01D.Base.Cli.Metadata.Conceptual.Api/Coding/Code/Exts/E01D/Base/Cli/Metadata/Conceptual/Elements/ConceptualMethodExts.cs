using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public static class ConceptualMethodExts
    {
        /// <summary>
        /// Gets whether the method is marked as abstract.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsAbstract(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsAbstract(method);
        }

        /// <summary>
        /// Gets whether the method is marked as async.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsAsync(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsAsync(method);
        }

        /// <summary>
        /// Gets whether the method is marked as extern.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsExtern(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsExtern(method);
        }

        /// <summary>
        /// Gets whether the method is marked as new.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsNew(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsNew(method);
        }

        /// <summary>
        /// Gets whether the method is marked as overridden.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsOverride(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsOverride(method);
        }

        /// <summary>
        /// Gets whether the method is marked as static.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsStatic(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsStatic(method);
        }

        /// <summary>
        /// Gets whether the method is marked as unsafe.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsUnsafe(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsUnsafe(method);
        }

        /// <summary>
        /// Gets whether the method is marked as virtual.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static bool IsVirtual(this ConceptualMethod_I method)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsVirtual(method);
        }

        /// <summary>
        /// Gets whether the method is marked as public
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPublic(ConceptualMethod_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsPublic(member);
        }

        /// <summary>
        /// Gets whether the method is marked as private
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsPrivate(ConceptualMethod_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsPrivate(member);
        }

        /// <summary>
        /// Gets whether the method is marked as internal
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsInternal(ConceptualMethod_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsInternal(member);
        }

        /// <summary>
        /// Gets whether the method is marked as protected
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool IsProtected(ConceptualMethod_I member)
        {
            return XConceptualMetadataBase.Api.Elements.Methods.IsProtected(member);
        }


    }
}
