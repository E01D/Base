using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Root.Coding.Code.Api.E01D.Json.Reflection;
using Root.Coding.Code.Domains.E01D;
//using Root.Coding.Code.Exts.E01D.Core.Reflection.Emit;
using Root.Coding.Code.Exts.E01D.Strings;
using Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe;
using Root.Coding.Code.Models.E01D.Core.Reflection.Emit.DelegateFactories;
using Root.Coding.Code.Models.E01D.Core.Reflection.Objects;
using Root.Coding.Code.Attributes.E01D.Json.Reflection;
using Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection;
using Root.Coding.Code.Exts.E01D.Core.Collections.ThreadSafe;
using Root.Coding.Code.Exts.E01D.Core.Reflection.Objects;
using Root.Coding.Code.Exts.E01D.Json.Reflection;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;
using Root.Coding.Code.Models.E01D.Json.Conversion;
using Type = System.Type;

namespace Root.Coding.Code.Api.E01D.Json
{
    public class JsonReflectionApi
    {
        private bool? _dynamicCodeGeneration;
        private bool? _fullyTrusted;

        public string IdPropertyName = "$id";
        public string RefPropertyName = "$ref";
        public string TypePropertyName = "$type";
        public string ValuePropertyName = "$value";
        public string ArrayValuesPropertyName = "$values";

        public string ShouldSerializePrefix = "ShouldSerialize";
        public string SpecifiedPostfix = "Specified";

        public JsonObjectAttributeApi ObjectAttributes { get; set; } = new JsonObjectAttributeApi();

        public JsonArrayAttributeApi ArrayAttributes { get; set; } = new JsonArrayAttributeApi();

        public JsonDictionaryAttributeApi DictionaryAttributes { get; set; } = new JsonDictionaryAttributeApi();
        public JsonContainerAttributeApi ContainerAttributes { get; set; } = new JsonContainerAttributeApi();


        private readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache;

#if !(NET20 || DOTNET)
        private readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;
        private ReflectionObject _metadataTypeAttributeReflectionObject;
#endif

        public JsonReflectionApi()
        {
            CreatorCache = XThreadSafe.ThreadSafeStore<Type, Func<object[], object>>(GetCreator);

#if !(NET20 || DOTNET)
            AssociatedMetadataTypesCache = XThreadSafe.ThreadSafeStore<Type, Type> (GetAssociateMetadataTypeFromAttribute);
#endif
        }

        public JsonCollectionApi Collections { get; set; } = new JsonCollectionApi();

    public T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
        {
            return Collections.CachedAttributeGetter.GetAttribute<T>(attributeProvider);
        }

#if HAVE_TYPE_DESCRIPTOR
        public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
        {
            typeConverter = TypeDescriptor.GetConverter(type);

            // use the objectType's TypeConverter if it has one and can convert to a string
            if (typeConverter != null)
            {
                Type converterType = typeConverter.GetType();

                if (!string.Equals(converterType.FullName, "System.ComponentModel.ComponentConverter", StringComparison.Ordinal)
                    && !string.Equals(converterType.FullName, "System.ComponentModel.ReferenceConverter", StringComparison.Ordinal)
                    && !string.Equals(converterType.FullName, "System.Windows.Forms.Design.DataSourceConverter", StringComparison.Ordinal)
                    && converterType != typeof(TypeConverter))
                {
                    return typeConverter.CanConvertTo(typeof(string));
                }

            }

            return false;
        }
#endif

#if HAVE_DATA_CONTRACTS
        public DataContractAttribute GetDataContractAttribute(Type type)
        {
            // DataContractAttribute does not have inheritance
            Type currentType = type;

            while (currentType != null)
            {
                DataContractAttribute result = Collections.CachedAttributeGetter.GetAttribute<DataContractAttribute>(currentType);
                if (result != null)
                {
                    return result;
                }

                currentType = XTypesBasic.Api.BaseType(currentType);
            }

            return null;
        }

        public DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
        {
            // DataMemberAttribute does not have inheritance

            // can't override a field
            if (XMembers.Api.MemberType(memberInfo) == MemberTypes.Field)
            {
                return Collections.CachedAttributeGetter.GetAttribute<DataMemberAttribute>(memberInfo);
            }

            // search property and then search base properties if nothing is returned and the property is virtual
            PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
            DataMemberAttribute result = Collections.CachedAttributeGetter.GetAttribute<DataMemberAttribute>(propertyInfo);
            if (result == null)
            {
                if (propertyInfo.IsVirtual())
                {
                    Type currentType = propertyInfo.DeclaringType;

                    while (result == null && currentType != null)
                    {
                        PropertyInfo baseProperty = (PropertyInfo)XTypes.Api.GetMemberInfoFromType(currentType, propertyInfo);
                        if (baseProperty != null && baseProperty.IsVirtual())
                        {
                            result = Collections.CachedAttributeGetter.GetAttribute<DataMemberAttribute>(baseProperty);
                        }

                        currentType = XTypesBasic.Api.BaseType(currentType);
                    }
                }
            }

            return result;
        }
#endif

        public MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
        {
            JsonObjectAttribute objectAttribute = GetCachedAttribute<JsonObjectAttribute>(objectType);

            if (objectAttribute != null)
            {
                return objectAttribute.Internals.MemberSerialization;
            }

#if HAVE_DATA_CONTRACTS
            DataContractAttribute dataContractAttribute = GetDataContractAttribute(objectType);
            if (dataContractAttribute != null)
            {
                return MemberSerialization.OptIn;
            }
#endif

#if HAVE_BINARY_SERIALIZATION
            if (!ignoreSerializableAttribute && IsSerializable(objectType))
            {
                return MemberSerialization.Fields;
            }
#endif

            // the default
            return MemberSerialization.OptOut;
        }

        public JsonConverter GetJsonConverter(object attributeProvider)
        {
            JsonConverterAttribute converterAttribute = GetCachedAttribute<JsonConverterAttribute>(attributeProvider);

            if (converterAttribute != null)
            {
                Func<object[], object> creator = CreatorCache.Get(converterAttribute.ConverterType);
                if (creator != null)
                {
                    return (JsonConverter)creator(converterAttribute.ConverterParameters);
                }
            }

            return null;
        }

        /// <summary>
        /// Lookup and create an instance of the <see cref="JsonConverter"/> type described by the argument.
        /// </summary>
        /// <param name="converterType">The <see cref="JsonConverter"/> type to create.</param>
        /// <param name="converterArgs">Optional arguments to pass to an initializing constructor of the JsonConverter.
        /// If <c>null</c>, the default constructor is used.</param>
        public JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs)
        {
            Func<object[], object> converterCreator = CreatorCache.Get(converterType);
            return (JsonConverter)converterCreator(converterArgs);
        }

        public NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] converterArgs)
        {
            Func<object[], object> converterCreator = CreatorCache.Get(namingStrategyType);
            return (NamingStrategy)converterCreator(converterArgs);
        }

        public NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
        {
            if (containerAttribute.Internal().NamingStrategyInstance == null)
            {
                if (containerAttribute.Internal().NamingStrategyType == null)
                {
                    return null;
                }

                containerAttribute.Internal().NamingStrategyInstance = CreateNamingStrategyInstance(containerAttribute.Internal().NamingStrategyType, containerAttribute.Internal().NamingStrategyParameters);
            }

            return containerAttribute.Internal().NamingStrategyInstance;
        }

        public Func<object[], object> GetCreator(Type type)
        {
            //Func<object> defaultConstructor = (XReflection.Api.HasDefaultConstructor(type, false))
            //    ? ReflectionDelegateFactory().CreateDefaultConstructor<object>(type)
            //    : null;

            //return (parameters) =>
            //{
            //    try
            //    {
            //        if (parameters != null)
            //        {
            //            Type[] paramTypes = parameters.Select(param => param.GetType()).ToArray();
            //            ConstructorInfo parameterizedConstructorInfo = type.GetConstructor(paramTypes);

            //            if (null != parameterizedConstructorInfo)
            //            {
            //                ObjectConstructor<object> parameterizedConstructor = ReflectionDelegateFactory().CreateParameterizedConstructor(parameterizedConstructorInfo);
            //                return parameterizedConstructor(parameters);
            //            }
            //            else
            //            {
            //                throw XExceptions.General.Exception("No matching parameterized constructor found for '{0}'.".FormatWith(CultureInfo.InvariantCulture, type));
            //            }
            //        }

            //        if (defaultConstructor == null)
            //        {
            //            throw XExceptions.General.Exception("No parameterless constructor defined for '{0}'.".FormatWith(CultureInfo.InvariantCulture, type));
            //        }

            //        return defaultConstructor();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw XExceptions.General.Exception("Error creating '{0}'.".FormatWith(CultureInfo.InvariantCulture, type), ex);
            //    }
            //};
            throw new System.NotImplementedException();
        }

#if !(NET20 || DOTNET)
        private Type GetAssociatedMetadataType(Type type)
        {
            return AssociatedMetadataTypesCache.Get(type);
        }

        private Type GetAssociateMetadataTypeFromAttribute(Type type)
        {
            Attribute[] customAttributes = XAttributes.Api.GetAttributes(type, null, true);

            foreach (Attribute attribute in customAttributes)
            {
                Type attributeType = attribute.GetType();

                // only test on attribute type name
                // attribute assembly could change because of type forwarding, etc
                if (string.Equals(attributeType.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
                {
                    const string metadataClassTypeName = "MetadataClassType";

                    if (_metadataTypeAttributeReflectionObject == null)
                    {
                        _metadataTypeAttributeReflectionObject = XReflectionObjects.Api.Create(attributeType, metadataClassTypeName);
                    }

                    return (Type)_metadataTypeAttributeReflectionObject.GetValue(attribute, metadataClassTypeName);
                }
            }

            return null;
        }
#endif

        private T GetAttribute<T>(Type type) where T : Attribute
        {
            T attribute;

#if !(NET20 || DOTNET)
            Type metadataType = GetAssociatedMetadataType(type);
            if (metadataType != null)
            {
                attribute = XAttributes.Api.GetAttribute<T>(metadataType, true);
                if (attribute != null)
                {
                    return attribute;
                }
            }
#endif

            attribute = XAttributes.Api.GetAttribute<T>(type, true);
            if (attribute != null)
            {
                return attribute;
            }

            foreach (Type typeInterface in type.GetInterfaces())
            {
                attribute = XAttributes.Api.GetAttribute<T>(typeInterface, true);
                if (attribute != null)
                {
                    return attribute;
                }
            }

            return null;
        }

        private T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
        {
            T attribute;

#if !(NET20 || DOTNET)
            Type metadataType = GetAssociatedMetadataType(memberInfo.DeclaringType);
            if (metadataType != null)
            {
                MemberInfo metadataTypeMemberInfo = XTypes.Api.GetMemberInfoFromType(metadataType, memberInfo);

                if (metadataTypeMemberInfo != null)
                {
                    attribute = XAttributes.Api.GetAttribute<T>(metadataTypeMemberInfo, true);
                    if (attribute != null)
                    {
                        return attribute;
                    }
                }
            }
#endif

            attribute = XAttributes.Api.GetAttribute<T>(memberInfo, true);
            if (attribute != null)
            {
                return attribute;
            }

            if (memberInfo.DeclaringType != null)
            {
                foreach (Type typeInterface in memberInfo.DeclaringType.GetInterfaces())
                {
                    MemberInfo interfaceTypeMemberInfo = XTypes.Api.GetMemberInfoFromType(typeInterface, memberInfo);

                    if (interfaceTypeMemberInfo != null)
                    {
                        attribute = XAttributes.Api.GetAttribute<T>(interfaceTypeMemberInfo, true);
                        if (attribute != null)
                        {
                            return attribute;
                        }
                    }
                }
            }

            return null;
        }

#if HAVE_NON_SERIALIZED_ATTRIBUTE
        public bool IsNonSerializable(object provider)
        {
#if HAVE_FULL_REFLECTION
            return (GetCachedAttribute<NonSerializedAttribute>(provider) != null);
#else
            FieldInfo fieldInfo = provider as FieldInfo;
            if (fieldInfo != null && (fieldInfo.Attributes & FieldAttributes.NotSerialized) == FieldAttributes.NotSerialized)
            {
                return true;
            }

            return false;
#endif
        }
#endif

#if HAVE_BINARY_SERIALIZATION
        public bool IsSerializable(object provider)
        {
#if HAVE_FULL_REFLECTION
            return (GetCachedAttribute<SerializableAttribute>(provider) != null);
#else
            Type type = provider as Type;
            if (type != null && (type.GetTypeInfo().Attributes & TypeAttributes.Serializable) == TypeAttributes.Serializable)
            {
                return true;
            }

            return false;
#endif
        }
#endif

        public T GetAttribute<T>(object provider) where T : Attribute
        {
            Type type = provider as Type;
            if (type != null)
            {
                return GetAttribute<T>(type);
            }

            MemberInfo memberInfo = provider as MemberInfo;
            if (memberInfo != null)
            {
                return GetAttribute<T>(memberInfo);
            }

            return XAttributes.Api.GetAttribute<T>(provider, true);
        }

#if DEBUG
        public void SetFullyTrusted(bool? fullyTrusted)
        {
            _fullyTrusted = fullyTrusted;
        }

        public void SetDynamicCodeGeneration(bool dynamicCodeGeneration)
        {
            _dynamicCodeGeneration = dynamicCodeGeneration;
        }
#endif

        public bool DynamicCodeGeneration
        {
#if HAVE_SECURITY_SAFE_CRITICAL_ATTRIBUTE
            [SecuritySafeCritical]
#endif
            get
            {
                if (_dynamicCodeGeneration == null)
                {
#if HAVE_CAS
                    try
                    {
                        new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
                        new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
                        new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
                        new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                        new SecurityPermission(PermissionState.Unrestricted).Demand();
                        _dynamicCodeGeneration = true;
                    }
                    catch (Exception)
                    {
                        _dynamicCodeGeneration = false;
                    }
#else
                    _dynamicCodeGeneration = false;
#endif
                }

                return _dynamicCodeGeneration.GetValueOrDefault();
            }
        }

        public bool FullyTrusted
        {
            get
            {
                if (_fullyTrusted == null)
                {
#if (DOTNET || PORTABLE || PORTABLE40)
                    _fullyTrusted = true;
#elif !(NET20 || NET35 || PORTABLE40)
                    AppDomain appDomain = AppDomain.CurrentDomain;

                    _fullyTrusted = appDomain.IsHomogenous && appDomain.IsFullyTrusted;
#else
                    try
                    {
                        new SecurityPermission(PermissionState.Unrestricted).Demand();
                        _fullyTrusted = true;
                    }
                    catch (Exception)
                    {
                        _fullyTrusted = false;
                    }
#endif
                }

                return _fullyTrusted.GetValueOrDefault();
            }
        }

        public ReflectionDelegateFactory ReflectionDelegateFactory()
        {

            //#if !(PORTABLE40 || PORTABLE || DOTNET || NETSTANDARD2_0)
            //                if (DynamicCodeGeneration)
            //                {
            //                    return XEmit.Api.DelegateFactories.Instances.Dynamic;
            //                }

            throw new System.NotImplementedException();
            //return XEmit.Api.DelegateFactories.Instances.LateBound;
            //#else
            //                return XEmit.Api.DelegateFactories.Instances.Expression;
            //#endif

        }

        
    }
}
