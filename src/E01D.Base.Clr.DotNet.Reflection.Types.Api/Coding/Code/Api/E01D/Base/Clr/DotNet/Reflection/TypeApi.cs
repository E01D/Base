using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Reflection;
using System.Text;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Serialization;
using Root.Coding.Code.Constants.E01D.Base.Types;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Reflection;
using Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection;
using Root.Coding.Code.Exts.E01D.Base.Clr.DotNet.Reflection.Types;
using Root.Coding.Code.Exts.E01D.Strings;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection;
using Root.Coding.Code.Models.E01D.Base.Types;
using Root.Coding.Code.Exts.E01D.Collections;


namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection
{
    public class BasicTypeApi
    {
        public Assembly Assembly(Type type)
        {
            return XTypesBasic.Api.Assembly(type);
        }

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return XTypesBasic.Api.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces)
        {
            return XTypesBasic.Api.AssignableToTypeName(type, fullTypeName, searchInterfaces);
        }

        

        public Type BaseType(Type type)
        {
            return XTypesBasic.Api.BaseType(type);
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject)
        {
            return XTypesBasic.Api.GetAllPropertyValues(targetObject);
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject, Type type)
        {
            return XTypesBasic.Api.GetAllPropertyValues(targetObject, type);
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject, GetAccessor[] allGetAccessors)
        {
            return XTypesBasic.Api.GetAllPropertyValues(targetObject, allGetAccessors); ;
        }

        public GetAccessor[] GetAllGetAccessors(Type type)
        {
            return XTypesBasic.Api.GetAllGetAccessors(type);
        }

        public object[] GetCustomAttributes(System.Type type)
        {
            return type.GetCustomAttributes(false);
        }

        public object[] GetCustomAttributes(System.Type type, bool inherit)
        {
            return type.GetCustomAttributes(inherit);
        }

        public object[] GetCustomAttributes(System.Type type, System.Type attributeType)
        {
            return GetCustomAttributes(type, attributeType, false);
        }

        public object[] GetCustomAttributes(System.Type type, System.Type attributeType, bool inherit)
        {
            return type.GetCustomAttributes(attributeType, inherit);
        }



        public PrimitiveTypeCode GetTypeCode(Type t)
        {
            bool isEnum;

            return GetTypeCode(t, out isEnum);
        }

        public PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
        {
            PrimitiveTypeCode typeCode;
            if (TypeMappings.TypeCodeMap.TryGetValue(t, out typeCode))
            {
                isEnum = false;
                return typeCode;
            }

            if (t.IsEnum())
            {
                isEnum = true;
                return GetTypeCode(Enum.GetUnderlyingType(t));
            }

            // performance?
            if (IsNullableType(t))
            {
                Type nonNullable = Nullable.GetUnderlyingType(t);
                if (nonNullable.IsEnum())
                {
                    Type nullableUnderlyingType = typeof(Nullable<>).MakeGenericType(Enum.GetUnderlyingType(nonNullable));
                    isEnum = true;
                    return GetTypeCode(nullableUnderlyingType);
                }
            }

            isEnum = false;
            return PrimitiveTypeCode.Object;
        }

        public TypeInformation GetTypeInformation(IConvertible convertable)
        {
            TypeInformation typeInformation = TypeMappings.PrimitiveTypeCodes[(int)convertable.GetTypeCode()];
            return typeInformation;
        }

        public Type GetObjectType(object v)
        {
            return XTypesBasic.GetObjectType(v);
        }

        public string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder)
        {
            string fullyQualifiedTypeName = GetFullyQualifiedTypeName(t, binder);

            switch (assemblyFormat)
            {
                case TypeNameAssemblyFormatHandling.Simple:
                    return RemoveAssemblyDetails(fullyQualifiedTypeName);
                case TypeNameAssemblyFormatHandling.Full:
                    return fullyQualifiedTypeName;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string RemoveAssemblyDetails(string fullyQualifiedTypeName)
        {
            StringBuilder builder = new StringBuilder();

            // loop through the type name and filter out qualified assembly details from nested type names
            bool writingAssemblyName = false;
            bool skippingAssemblyDetails = false;
            for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
            {
                char current = fullyQualifiedTypeName[i];
                switch (current)
                {
                    case '[':
                        writingAssemblyName = false;
                        skippingAssemblyDetails = false;
                        builder.Append(current);
                        break;
                    case ']':
                        writingAssemblyName = false;
                        skippingAssemblyDetails = false;
                        builder.Append(current);
                        break;
                    case ',':
                        if (!writingAssemblyName)
                        {
                            writingAssemblyName = true;
                            builder.Append(current);
                        }
                        else
                        {
                            skippingAssemblyDetails = true;
                        }
                        break;
                    default:
                        if (!skippingAssemblyDetails)
                        {
                            builder.Append(current);
                        }
                        break;
                }
            }

            return builder.ToString();
        }

        public bool HasDefaultConstructor(Type t, bool nonPublic)
        {
            return XTypesBasic.HasDefaultConstructor(t, nonPublic);
        }

        

        public ConstructorInfo GetDefaultConstructor(Type t)
        {
            return XTypesBasic.GetDefaultConstructor(t);
        }

        public ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
        {
            return XTypesBasic.GetDefaultConstructor(t, nonPublic);
        }

        /// <summary>
        /// Gets the type of the typed collection's items.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The type of the typed collection's items.</returns>
        public Type GetCollectionItemType(Type type)
        {
            XValidation.ArgumentNotNull(type, nameof(type));
            Type genericListType;

            if (type.IsArray)
            {
                return type.GetElementType();
            }
            if (ImplementsGenericDefinition(type, typeof(IEnumerable<>), out genericListType))
            {
                if (genericListType.IsGenericTypeDefinition())
                {
                    throw new Exception($"Type {type} is not a collection.");
                }

                return genericListType.GetGenericArguments()[0];
            }
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return null;
            }

            throw new Exception($"Type {type} is not a collection.");
        }

        public void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
        {
            XValidation.ArgumentNotNull(dictionaryType, nameof(dictionaryType));

            Type genericDictionaryType;
            if (ImplementsGenericDefinition(dictionaryType, typeof(IDictionary<,>), out genericDictionaryType))
            {
                if (genericDictionaryType.IsGenericTypeDefinition())
                {
                    throw new Exception($"Type {dictionaryType} is not a dictionary.");
                }

                Type[] dictionaryGenericArguments = genericDictionaryType.GetGenericArguments();

                keyType = dictionaryGenericArguments[0];
                valueType = dictionaryGenericArguments[1];
                return;
            }
            if (typeof(IDictionary).IsAssignableFrom(dictionaryType))
            {
                keyType = null;
                valueType = null;
                return;
            }

            throw new Exception($"Type {dictionaryType} is not a dictionary.");
        }

        


        public Type EnsureNotNullableType(Type t)
        {
            return (IsNullableType(t))
                ? Nullable.GetUnderlyingType(t)
                : t;
        }

        public string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder)
        {
            if (binder != null)
            {
                string assemblyName;
                string typeName;
                binder.BindToName(t, out assemblyName, out typeName);
#if (NET20 || NET35)
                // for older SerializationBinder implementations that didn't have BindToName
                if (assemblyName == null & typeName == null)
                {
                    return t.AssemblyQualifiedName;
                }
#endif
                return typeName + (assemblyName == null ? "" : ", " + assemblyName);
            }

            return t.AssemblyQualifiedName;
        }

        public bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
        {
            Type implementingType;
            return ImplementsGenericDefinition(type, genericInterfaceDefinition, out implementingType);
        }

        public bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
        {
            XValidation.ArgumentNotNull(type, nameof(type));
            XValidation.ArgumentNotNull(genericInterfaceDefinition, nameof(genericInterfaceDefinition));

            if (!genericInterfaceDefinition.IsInterface() || !genericInterfaceDefinition.IsGenericTypeDefinition())
            {
                throw new ArgumentNullException($"'{genericInterfaceDefinition}' is not a generic interface definition.");
            }

            if (type.IsInterface())
            {
                if (type.IsGenericType())
                {
                    Type interfaceDefinition = type.GetGenericTypeDefinition();

                    if (genericInterfaceDefinition == interfaceDefinition)
                    {
                        implementingType = type;
                        return true;
                    }
                }
            }

            foreach (Type i in type.GetInterfaces())
            {
                if (i.IsGenericType())
                {
                    Type interfaceDefinition = i.GetGenericTypeDefinition();

                    if (genericInterfaceDefinition == interfaceDefinition)
                    {
                        implementingType = i;
                        return true;
                    }
                }
            }

            implementingType = null;
            return false;
        }

        public bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
        {
            Type implementingType;
            return InheritsGenericDefinition(type, genericClassDefinition, out implementingType);
        }

        public bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
        {
            XValidation.ArgumentNotNull(type, nameof(type));
            XValidation.ArgumentNotNull(genericClassDefinition, nameof(genericClassDefinition));

            if (!genericClassDefinition.IsClass() || !genericClassDefinition.IsGenericTypeDefinition())
            {
                throw new ArgumentNullException($"'{genericClassDefinition}' is not a generic class definition.");
            }

            return InheritsGenericDefinitionInternal(type, genericClassDefinition, out implementingType);
        }

        private bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
        {
            if (currentType.IsGenericType())
            {
                Type currentGenericClassDefinition = currentType.GetGenericTypeDefinition();

                if (genericClassDefinition == currentGenericClassDefinition)
                {
                    implementingType = currentType;
                    return true;
                }
            }

            if (currentType.BaseType() == null)
            {
                implementingType = null;
                return false;
            }

            return InheritsGenericDefinitionInternal(currentType.BaseType(), genericClassDefinition, out implementingType);
        }

        public TypeNameKey SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
        {
            int? assemblyDelimiterIndex = GetAssemblyDelimiterIndex(fullyQualifiedTypeName);

            string typeName;
            string assemblyName;

            if (assemblyDelimiterIndex != null)
            {
                typeName = fullyQualifiedTypeName.Trim(0, assemblyDelimiterIndex.GetValueOrDefault());
                assemblyName = fullyQualifiedTypeName.Trim(assemblyDelimiterIndex.GetValueOrDefault() + 1, fullyQualifiedTypeName.Length - assemblyDelimiterIndex.GetValueOrDefault() - 1);
            }
            else
            {
                typeName = fullyQualifiedTypeName;
                assemblyName = null;
            }

            return new TypeNameKey(assemblyName, typeName);
        }

        private int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
        {
            // we need to get the first comma following all surrounded in brackets because of generic types
            // e.g. System.Collections.Generic.Dictionary`2[[System.String, mscorlib,Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
            int scope = 0;
            for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
            {
                char current = fullyQualifiedTypeName[i];
                switch (current)
                {
                    case '[':
                        scope++;
                        break;
                    case ']':
                        scope--;
                        break;
                    case ',':
                        if (scope == 0)
                        {
                            return i;
                        }
                        break;
                }
            }

            return null;
        }

        

        public IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
        {
            XValidation.ArgumentNotNull(targetType, nameof(targetType));

            List<MemberInfo> fieldInfos = new List<MemberInfo>(targetType.GetFields(bindingAttr));
#if !PORTABLE
            // Type.GetFields doesn't return inherited private fields
            // manually find private fields from base class
            GetChildPrivateFields(fieldInfos, targetType, bindingAttr);
#endif

            return fieldInfos.Cast<FieldInfo>();
        }

#if !PORTABLE
        private void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
        {
            // fix weirdness with private FieldInfos only being returned for the current Type
            // find base type fields and add them to result
            if ((bindingAttr & BindingFlags.NonPublic) != 0)
            {
                // modify flags to not search for public fields
                BindingFlags nonPublicBindingAttr = bindingAttr.RemoveFlag(BindingFlags.Public);

                while ((targetType = targetType.BaseType()) != null)
                {
                    // filter out protected fields
                    IEnumerable<FieldInfo> childPrivateFields =
                        targetType.GetFields(nonPublicBindingAttr).Where(f => f.IsPrivate);

                    initialFields.AddRange(childPrivateFields);
                }
            }
        }
#endif

        

        public object GetDefaultValue(Type type)
        {
            if (!type.IsValueType())
            {
                return null;
            }

            switch (GetTypeCode(type))
            {
                case PrimitiveTypeCode.Boolean:
                    return false;
                case PrimitiveTypeCode.Char:
                case PrimitiveTypeCode.SByte:
                case PrimitiveTypeCode.Byte:
                case PrimitiveTypeCode.Int16:
                case PrimitiveTypeCode.UInt16:
                case PrimitiveTypeCode.Int32:
                case PrimitiveTypeCode.UInt32:
                    return 0;
                case PrimitiveTypeCode.Int64:
                case PrimitiveTypeCode.UInt64:
                    return 0L;
                case PrimitiveTypeCode.Single:
                    return 0f;
                case PrimitiveTypeCode.Double:
                    return 0.0;
                case PrimitiveTypeCode.Decimal:
                    return 0m;
                case PrimitiveTypeCode.DateTime:
                    return new DateTime();
#if HAVE_BIG_INTEGER
                case PrimitiveTypeCode.BigInteger:
                    return new BigInteger();
#endif
                case PrimitiveTypeCode.Guid:
                    return new Guid();
#if HAVE_DATE_TIME_OFFSET
                case PrimitiveTypeCode.DateTimeOffset:
                    return new DateTimeOffset();
#endif
            }

            if (IsNullable(type))
            {
                return null;
            }

            // possibly use IL initobj for perf here?
            return Activator.CreateInstance(type);
        }






        public Type GetAssociatedMetadataType(Type type)
        {
            //return AssociatedMetadataTypesCache.Get(type);
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
        }

        public Type GetAssociateMetadataTypeFromAttribute(Type type)
        {
            //Attribute[] customAttributes = ReflectionUtils.GetAttributes(type, null, true);

            //foreach (Attribute attribute in customAttributes)
            //{
            //    Type attributeType = attribute.GetType();

            //    // only test on attribute type name
            //    // attribute assembly could change because of type forwarding, etc
            //    if (string.Equals(attributeType.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
            //    {
            //        const string metadataClassTypeName = "MetadataClassType";

            //        if (_metadataTypeAttributeReflectionObject == null)
            //        {
            //            _metadataTypeAttributeReflectionObject = ReflectionObject.Create(attributeType, metadataClassTypeName);
            //        }

            //        return (Type)_metadataTypeAttributeReflectionObject.GetValue(attribute, metadataClassTypeName);
            //    }
            //}

            //return null;
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
        }

        public bool IsAbstract(Type type)
        {
            return XTypesBasic.Api.IsAbstract(type);
        }

        /// <summary>
        /// Gets whether the specified type is an array.
        /// </summary>
        public bool IsArray(Type type)
        {
            return XTypesBasic.Api.IsArray(type);
        }

        public bool IsAttribute(Type type)
        {
            return XTypesBasic.Api.IsAttribute(type);
        }

        /// <summary>
        /// Gets whether the specified type is a class.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsClass(Type type)
        {
            return XTypesBasic.Api.IsClass(type);
        }

        public bool IsDefined(Type type, Type attributeType, bool inherit)
        {
            return XTypesBasic.Api.IsDefined(type, attributeType, inherit);
        }

        /// <summary>
        /// Gets whether the specified type is an enumeration
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsDelegate(Type type)
        {
            return XTypesBasic.Api.IsDelegate(type);
        }

        

        public bool IsDictionaryType(Type type)
        {
            XValidation.ArgumentNotNull(type, nameof(type));

            if (typeof(IDictionary).IsAssignableFrom(type))
            {
                return true;
            }
            if (ImplementsGenericDefinition(type, typeof(IDictionary<,>)))
            {
                return true;
            }
#if HAVE_READ_ONLY_COLLECTIONS
            if (ImplementsGenericDefinition(type, typeof(IReadOnlyDictionary<,>)))
            {
                return true;
            }
#endif

            return false;
        }

        /// <summary>
        /// Gets whether the specified type is an enumeration
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsEnum(Type type)
        {
            return XTypesBasic.Api.IsEnum(type);
        }

        public bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
        {
            return XTypesBasic.Api.IsGenericDefinition(type, genericInterfaceDefinition);
        }

        public bool IsGenericTypeDefinition(Type type)
        {
            return XTypesBasic.Api.IsGenericTypeDefinition(type);
        }

        public bool IsGenericType(Type type)
        {
            return XTypesBasic.Api.IsGenericType(type);
        }

        public bool ContainsGenericParameters(Type type)
        {
            return XTypesBasic.Api.ContainsGenericParameters(type);
        }

        public bool IsSealed(Type type)
        {
            return XTypesBasic.Api.IsSealed(type);
        }

        /// <summary>
        /// Gets whether the specified type is a interface.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsInterface(Type type)
        {
            return XTypesBasic.Api.IsInterface(type);
        }

        public bool IsNullable(Type t)
        {
            return XTypesBasic.Api.IsNullable(t);
        }

        public bool IsNullableType(Type t)
        {
            return XTypesBasic.Api.IsNullableType(t);
        }

        /// <summary>
        /// Gets whether the specified type is a pointer
        /// </summary>
        public bool IsPointer(Type type)
        {
            return XTypesBasic.Api.IsPointer(type);
        }

        public bool IsPrimitive(Type type)
        {
            return XTypesBasic.Api.IsPrimitive(type);
        }

        /// <summary>
        /// Gets whether the specified type is a valuetype
        /// </summary>
        public bool IsValueType(Type type)
        {
            return XTypesBasic.IsValueType(type);
        }

        public bool IsVisible(Type type)
        {
            return XTypesBasic.Api.IsVisible(type);
        }

        
        

        public IEnumerable<MethodInfo> GetMethods(Type type, BindingFlags bindingFlags)
        {
            return XTypesBasic.Api.GetMethods(type, bindingFlags);
        }

        

        

        public Type[] GetGenericArguments(Type type)
        {
            return XTypesBasic.Api.GetGenericArguments(type);
        }

        public IEnumerable<Type> GetInterfaces(Type type)
        {
            return XTypesBasic.Api.GetGenericArguments(type);
        }

        public IEnumerable<MethodInfo> GetMethods(Type type)
        {
            return XTypesBasic.Api.GetMethods(type);
        }

        public bool IsSubclassOf(Type type, Type c)
        {
            return XTypesBasic.Api.IsSubclassOf(type, c);
        }

        public bool IsAssignableFrom(Type type, Type c)
        {
            return XTypesBasic.Api.IsAssignableFrom(type, c);
        }


        public bool IsInstanceOfType(Type type, object o)
        {
            return XTypesBasic.Api.IsInstanceOfType(type, o);
        }



    }
}
