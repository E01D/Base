using System;
using Root.Coding.Code.Enums.E01D.Json.Reflection;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;

namespace Root.Coding.Code.Attributes.E01D.Json.Reflection
{
    public class JsonContainerAttributeInternals
    {
        /// <summary>
        /// Gets or sets a value that indicates whether to preserve object references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep object reference; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public bool? IsReference { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve collection's items references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep collection's items object references; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public bool? ItemIsReference { get; set; }

        /// <summary>
        /// Gets or sets the reference loop handling used when serializing the collection's items.
        /// </summary>
        /// <value>The reference loop handling.</value>
        public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

        /// <summary>
        /// Gets or sets the type name handling used when serializing the collection's items.
        /// </summary>
        /// <value>The type name handling.</value>
        public TypeNameHandling? ItemTypeNameHandling { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the <see cref="NamingStrategy"/>.
        /// </summary>
        /// <value>The <see cref="Type"/> of the <see cref="NamingStrategy"/>.</value>
        public Type NamingStrategyType { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the collection's items converter.
        /// </summary>
        /// <value>The collection's items converter.</value>
        public Type ItemConverterType { get; set; }

        /// <summary>
        /// The parameter list to use when constructing the <see cref="JsonConverter"/> described by <see cref="ItemConverterType"/>.
        /// If <c>null</c>, the default constructor is used.
        /// When non-<c>null</c>, there must be a constructor defined in the <see cref="JsonConverter"/> that exactly matches the number,
        /// order, and type of these parameters.
        /// </summary>
        /// <example>
        /// <code>
        /// [JsonContainer(ItemConverterType = typeof(MyContainerConverter), ItemConverterParameters = new object[] { 123, "Four" })]
        /// </code>
        /// </example>
        public object[] ItemConverterParameters { get; set; }

        public NamingStrategy NamingStrategyInstance { get; set; }

        public object[] NamingStrategyParameters { get; set; }
    }
}
