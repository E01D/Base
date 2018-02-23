using System;
using Root.Coding.Code.Attributes.E01D.Json.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Reflection;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;


namespace Root.Coding.Code.Exts.E01D.Json.Reflection
{
    public static class JsonContainerAttributeExts
    {
        public static JsonContainerAttributeInternals Intenral(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.Internal(attribute);
        }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the <see cref="NamingStrategy"/>.
        /// </summary>
        /// <value>The <see cref="Type"/> of the <see cref="NamingStrategy"/>.</value>
        public static Type NamingStrategyType(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.NamingStrategyType(attribute);
        }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the <see cref="NamingStrategy"/>.
        /// </summary>
        /// <value>The <see cref="Type"/> of the <see cref="NamingStrategy"/>.</value>
        public static void NamingStrategyType(this JsonContainerAttribute attribute, Type value)
        {
            XJsonReflection.Api.ContainerAttributes.NamingStrategyType(attribute, value);
        }

        /// <summary>
        /// The parameter list to use when constructing the <see cref="NamingStrategy"/> described by <see cref="NamingStrategyType"/>.
        /// If <c>null</c>, the default constructor is used.
        /// When non-<c>null</c>, there must be a constructor defined in the <see cref="NamingStrategy"/> that exactly matches the number,
        /// order, and type of these parameters.
        /// </summary>
        /// <example>
        /// <code>
        /// [JsonContainer(NamingStrategyType = typeof(MyNamingStrategy), NamingStrategyParameters = new object[] { 123, "Four" })]
        /// </code>
        /// </example>
        public static object[] NamingStrategyParameters(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.NamingStrategyParameters(attribute);
        }

        /// <summary>
        /// The parameter list to use when constructing the <see cref="NamingStrategy"/> described by <see cref="NamingStrategyType"/>.
        /// If <c>null</c>, the default constructor is used.
        /// When non-<c>null</c>, there must be a constructor defined in the <see cref="NamingStrategy"/> that exactly matches the number,
        /// order, and type of these parameters.
        /// </summary>
        /// <example>
        /// <code>
        /// [JsonContainer(NamingStrategyType = typeof(MyNamingStrategy), NamingStrategyParameters = new object[] { 123, "Four" })]
        /// </code>
        /// </example>
        public static void NamingStrategyParameters(this JsonContainerAttribute attribute, object[] value)
        {
            XJsonReflection.Api.ContainerAttributes.NamingStrategyParameters(attribute, value);
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve object references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep object reference; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public static bool IsReference(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.IsReference(attribute);

        }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve object references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep object reference; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public static void IsReference(this JsonContainerAttribute attribute, bool value)
        {

            XJsonReflection.Api.ContainerAttributes.IsReference(attribute, value);
        }



        /// <summary>
        /// Gets or sets a value that indicates whether to preserve collection's items references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep collection's items object references; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public static bool ItemIsReference(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.ItemIsReference(attribute);

        }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve collection's items references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep collection's items object references; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public static void ItemIsReference(this JsonContainerAttribute attribute, bool value)
        {
            XJsonReflection.Api.ContainerAttributes.ItemIsReference(attribute, value);
        }

        /// <summary>
        /// Gets or sets the reference loop handling used when serializing the collection's items.
        /// </summary>
        /// <value>The reference loop handling.</value>
        public static ReferenceLoopHandling ItemReferenceLoopHandling(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.ItemReferenceLoopHandling(attribute);

        }

        /// <summary>
        /// Gets or sets the reference loop handling used when serializing the collection's items.
        /// </summary>
        /// <value>The reference loop handling.</value>
        public static void ItemReferenceLoopHandling(this JsonContainerAttribute attribute, ReferenceLoopHandling value)
        {
            XJsonReflection.Api.ContainerAttributes.ItemReferenceLoopHandling(attribute, value);
        }


        /// <summary>
        /// Gets or sets the type name handling used when serializing the collection's items.
        /// </summary>
        /// <value>The type name handling.</value>
        public static TypeNameHandling ItemTypeNameHandling(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.ItemTypeNameHandling(attribute);
        }

        /// <summary>
        /// Gets or sets the type name handling used when serializing the collection's items.
        /// </summary>
        /// <value>The type name handling.</value>
        public static void ItemTypeNameHandling(this JsonContainerAttribute attribute, TypeNameHandling value)
        {
            XJsonReflection.Api.ContainerAttributes.ItemTypeNameHandling(attribute, value);
        }

        public static JsonContainerAttributeInternals Internal(this JsonContainerAttribute attribute)
        {
            return XJsonReflection.Api.ContainerAttributes.Internal(attribute);
        }
    }
}
