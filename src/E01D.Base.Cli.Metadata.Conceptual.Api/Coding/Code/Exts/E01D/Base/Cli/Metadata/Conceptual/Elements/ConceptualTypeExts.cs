using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    public static class ConceptualTypeExts
    {
        /// <summary>
        /// Gets the type handle associated with the specified type;
        /// </summary>
        /// <param name="type">The type from which to get the associated handle.</param>
        /// <returns>Returns the type handle associated with the specified type.  If one is not associated, it returns the default handle.</returns>
        public static RuntimeTypeHandle TypeHandle(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.TypeHandle(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an array.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an array.</returns>
        public static bool IsArray(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsArray(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an array.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an array.</returns>
        public static bool IsClass(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsClass(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an delegate.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an delegate.</returns>
        public static bool IsDelegate(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsDelegate(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an enum.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an enum.</returns>
        public static bool IsEnum(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsEnum(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an interface.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an interface.</returns>
        public static bool IsInterface(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsInterface(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an pointer.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an pointer.</returns>
        public static bool IsPointer(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsPointer(type);
        }

        /// <summary>
        /// Gets whethere the specified type is an struct.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>Returns true if the type is an struct.</returns>
        public static bool IsStruct(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsStruct(type);
        }

        

        

        

        public static bool IsTypeParameter(this ConceptualType_I type)
        {
            return XConceptualMetadataBase.Api.Elements.Types.IsTypeParameter(type);
        }
    }
}
