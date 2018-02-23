using System;
using Root.Coding.Code.Attributes.E01D.Json.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Reflection;
using Root.Coding.Code.Exts.E01D.Json.Reflection;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;


namespace Root.Coding.Code.Api.E01D.Json.Reflection
{
    public class JsonContainerAttributeApi
    {
        public void New(JsonContainerAttribute attribute)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonContainerAttribute"/> class with the specified container Id.
        /// </summary>
        /// <param name="id">The container Id.</param>
        public void New(JsonContainerAttribute attribute, string id)
        {
            attribute.Internal().Id = id;
        }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the <see cref="NamingStrategy"/>.
        /// </summary>
        /// <value>The <see cref="Type"/> of the <see cref="NamingStrategy"/>.</value>
        public Type NamingStrategyType(JsonContainerAttribute attribute)
        {
            return attribute.Internal().NamingStrategyType; 
        }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the <see cref="NamingStrategy"/>.
        /// </summary>
        /// <value>The <see cref="Type"/> of the <see cref="NamingStrategy"/>.</value>
        public void NamingStrategyType(JsonContainerAttribute attribute, Type value)
        {
            
            attribute.Internal().NamingStrategyType = value;
            attribute.Internal().NamingStrategyInstance = null;
            
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
        public object[] NamingStrategyParameters(JsonContainerAttribute attribute)
        {
            return attribute.Internal().NamingStrategyParameters; 
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
        public void NamingStrategyParameters(JsonContainerAttribute attribute, object[] value)
        {
            attribute.Internal().NamingStrategyParameters = value;
            attribute.Internal().NamingStrategyInstance = null;   
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve object references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep object reference; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public bool IsReference(JsonContainerAttribute attribute)
        {
            return attribute.Internal().IsReference ?? default(bool);
            
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve object references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep object reference; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public void IsReference(JsonContainerAttribute attribute, bool value)
        {
            
            attribute.Internal().IsReference = value; 
        }

        

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve collection's items references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep collection's items object references; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public bool ItemIsReference(JsonContainerAttribute attribute)
        {
            return attribute.Internal().ItemIsReference ?? default(bool); 
            
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to preserve collection's items references.
        /// </summary>
        /// <value>
        /// 	<c>true</c> to keep collection's items object references; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        public void ItemIsReference(JsonContainerAttribute attribute, bool value)
        {
            attribute.Internal().ItemIsReference = value; 
        }

        /// <summary>
        /// Gets or sets the reference loop handling used when serializing the collection's items.
        /// </summary>
        /// <value>The reference loop handling.</value>
        public ReferenceLoopHandling ItemReferenceLoopHandling(JsonContainerAttribute attribute)
        {
            return attribute.Internal().ItemReferenceLoopHandling ?? default(ReferenceLoopHandling); 
            
        }

        /// <summary>
        /// Gets or sets the reference loop handling used when serializing the collection's items.
        /// </summary>
        /// <value>The reference loop handling.</value>
        public void ItemReferenceLoopHandling(JsonContainerAttribute attribute, ReferenceLoopHandling value)
        {
            attribute.Internal().ItemReferenceLoopHandling = value; 
        }


        /// <summary>
        /// Gets or sets the type name handling used when serializing the collection's items.
        /// </summary>
        /// <value>The type name handling.</value>
        public TypeNameHandling ItemTypeNameHandling(JsonContainerAttribute attribute)
        {
            return attribute.Internal().ItemTypeNameHandling ?? default(TypeNameHandling); 
        }

        /// <summary>
        /// Gets or sets the type name handling used when serializing the collection's items.
        /// </summary>
        /// <value>The type name handling.</value>
        public void ItemTypeNameHandling(JsonContainerAttribute attribute, TypeNameHandling value)
        {
            attribute.Internal().ItemTypeNameHandling = value; 
        }

        public JsonContainerAttributeInternals Internal(JsonContainerAttribute attribute)
        {
            switch (attribute.Kind)
            {
                case JsonContainerKind.Array:
                {
                    return XJsonReflection.Api.ArrayAttributes.Internal((JsonArrayAttribute) attribute);
                }
                case JsonContainerKind.Dictionary:
                {
                        return XJsonReflection.Api.DictionaryAttributes.Internal((JsonDictionaryAttribute)attribute);
                    break;
                }
                case JsonContainerKind.Object:
                {
                        return XJsonReflection.Api.ObjectAttributes.Internal((JsonObjectAttribute)attribute);
                    break;
                }
                default:
                {
                    throw XExceptions.NotSupported.EnumerationValueIsNotValid();
                }
            }
        }
    }
}
