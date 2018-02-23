using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Serialization;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Reflection;
using Root.Coding.Code.Models.E01D.Base.Types;
using Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection;
using Root.Coding.Code.Exts.E01D.Base.Clr.DotNet.Reflection.Types;
using Root.Coding.Code.Statics.E01D.Base.Clr.DotNet.Reflection;


namespace Root.Coding.Code.Api.E01D.Base
{
    public class TypeApi
    {
        public ConstructorInfo GetConstructor(Type type, IList<Type> parameterTypes)
        {
            return GetConstructor(type, ReflectionStatics.DefaultFlags, null, parameterTypes, null);
        }

        public ConstructorInfo GetConstructor(Type type, BindingFlags bindingFlags, object placeholder1, IList<Type> parameterTypes, object placeholder2)
        {
            return MethodBinder.SelectMethod(type.GetConstructors(bindingFlags), parameterTypes);
        }
        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return XBaseTypes.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces)
        {
            return XBaseTypes.AssignableToTypeName(type, fullTypeName, searchInterfaces);
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject)
        {
            return XBaseTypes.Api.GetAllPropertyValues(targetObject);
        }

        public IEnumerable<ConstructorInfo> GetConstructors(Type type)
        {
            return type.GetConstructors(ReflectionStatics.DefaultFlags);
        }

        public IEnumerable<ConstructorInfo> GetConstructors(Type type, BindingFlags bindingFlags)
        {
            return type.GetTypeInfo().DeclaredConstructors.Where(c => XMembers.Api.TestAccessibility(c, bindingFlags));
        }

        public MemberInfo[] GetMember(Type type, string member)
        {
            return type.GetMemberInternal(member, null, ReflectionStatics.DefaultFlags);
        }

        

        public MemberInfo[] GetMember(Type type, string member, BindingFlags bindingFlags)
        {
            return type.GetMemberInternal(member, null, bindingFlags);
        }

        public MemberInfo[] GetMemberInternal(Type type, string member, MemberTypes? memberType, BindingFlags bindingFlags)
        {
            return type.GetTypeInfo().GetMembersRecursive().Where(m =>
                m.Name == member &&
                // test type before accessibility - accessibility doesn't support some types
                (memberType == null || (m.MemberType() | memberType) == memberType) &&
                XMembers.Api.TestAccessibility(m, bindingFlags)).ToArray();
        }

        public TypeId_I GetTypeId<T>()
        {
            return XTypeIdentification.GetTypeId<T>();
        }

        public RuntimeTypeHandle GetTypeHandle(TypeId_I zTypeId)
        {
            XTypeIdentification.GetTypeHandle(zTypeId, out RuntimeTypeHandle typeHandle);

            return typeHandle;
        }

        public TypeId_I GetTypeId(Type type)
        {
            return XTypeIdentification.GetTypeId(type);
        }

        public TypeId_I GetTypeId(RuntimeTypeHandle handle)
        {
            return XTypeIdentification.GetTypeId(handle);
        }

        public bool GetTypeId(RuntimeTypeHandle typeHandle, out TypeId_I id)
        {
            return XTypeIdentification.GetTypeId(typeHandle, out id);
        }

        public Type GetObjectType(object v)
        {
            return XBaseTypes.GetObjectType(v);
        }

        public string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder)
        {
            return XBaseTypes.GetTypeName(t, assemblyFormat, binder);
        }

        public string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder)
        {
            return XBaseTypes.GetFullyQualifiedTypeName(t, binder);
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject, Type type)
        {
            return XBaseTypes.Api.GetAllPropertyValues(targetObject, type);
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject, GetAccessor[] allGetAccessors)
        {
            return XBaseTypes.Api.GetAllPropertyValues(targetObject, allGetAccessors);
        }

        public GetAccessor[] GetAllGetAccessors(Type type)
        {
            return XBaseTypes.Api.GetAllGetAccessors(type);
        }

        public T GetAttribute<T>(Type type) where T : Attribute
        {
            T attribute;

            Type metadataType = XBaseTypes.GetAssociatedMetadataType(type);
            if (metadataType != null)
            {
                attribute = XAttributes.GetAttribute<T>(metadataType, true);
                if (attribute != null)
                {
                    return attribute;
                }
            }

            attribute = XAttributes.GetAttribute<T>(type, true);
            if (attribute != null)
            {
                return attribute;
            }

            foreach (Type typeInterface in type.GetInterfaces())
            {
                attribute = XAttributes.GetAttribute<T>(typeInterface, true);
                if (attribute != null)
                {
                    return attribute;
                }
            }

            return null;
        }

        public object[] GetCustomAttributes(System.Type type)
        {
            return XBaseTypes.Api.GetCustomAttributes(type);
        }

        public object[] GetCustomAttributes(System.Type type, bool inherit)
        {
            return XBaseTypes.Api.GetCustomAttributes(type, inherit);
        }

        public object[] GetCustomAttributes(System.Type type, System.Type attributeType)
        {
            return XBaseTypes.Api.GetCustomAttributes(type, attributeType);
        }

        

        public object[] GetCustomAttributes(System.Type type, System.Type attributeType, bool inherit)
        {
            return XBaseTypes.Api.GetCustomAttributes(type, attributeType, inherit);
        }

        public bool GetTypeHandle(long id, out RuntimeTypeHandle typeHandle)
        {
            return XTypeIdentification.GetTypeHandle(id, out typeHandle);
        }

        public bool GetTypeHandle(TypeId_I id, out RuntimeTypeHandle typeHandle)
        {
            return XTypeIdentification.GetTypeHandle(id, out typeHandle);
        }



        public bool ImplementInterface(Type type, Type interfaceType)
        {
            for (Type currentType = type; currentType != null; currentType = XBaseTypes.BaseType(currentType))
            {
                IEnumerable<Type> interfaces = currentType.GetInterfaces();
                foreach (Type i in interfaces)
                {
                    if (i == interfaceType || (i != null && ImplementInterface(i, interfaceType)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gets whether the specified type is an array.
        /// </summary>
        public bool IsArray(Type type)
        {
            return XBaseTypes.Api.IsArray(type);
        }

        

        /// <summary>
        /// Gets whether the specified type is a class.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsClass(Type type)
        {
            return type.IsClass;
        }

        /// <summary>
        /// Gets whether the specified type is an enumeration
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsDelegate(Type type)
        {
            return type.IsSubclassOf(typeof(Delegate)) || type == typeof(Delegate);
        }

        /// <summary>
        /// Gets whether the specified type is an enumeration
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsEnum(Type type)
        {
            return type.IsEnum;
        }

        /// <summary>
        /// Gets whether the specified type is a interface.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsInterface(Type type)
        {
            return type.IsInterface;
        }

        /// <summary>
        /// Gets whether the specified type is a pointer
        /// </summary>
        public bool IsPointer(Type type)
        {
            return type.IsPointer;
        }

        /// <summary>
        /// Gets whether the specified type is a valuetype
        /// </summary>
        public bool IsValueType(Type type)
        {
            return type.IsValueType;
        }


        public bool IsAttribute(Type type)
        {
            return XBaseTypes.IsAttribute(type);
        }


        public bool IsSealed(Type type)
        {
            return XBaseTypes.IsSealed(type); 
        }

        public bool IsAbstract(Type type)
        {
            return XBaseTypes.IsAbstract(type);
        }

        public bool IsVisible(Type type)
        {
            return XBaseTypes.IsVisible(type);
        }

        public bool IsPrimitive(Type type)
        {
            return XBaseTypes.IsPrimitive(type);
        }

        public bool IsDicitonaryType(Type type)
        {
            return XBaseTypes.IsDictionaryType(type);
        }

        

        public string RemoveAssemblyDetails(string fullyQualifiedTypeName)
        {
            return XBaseTypes.RemoveAssemblyDetails(fullyQualifiedTypeName);
        }

        public IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingFlags)
        {
            IList<FieldInfo> fields = (bindingFlags.HasFlag(BindingFlags.DeclaredOnly))
                ? type.GetTypeInfo().DeclaredFields.ToList()
                : type.GetTypeInfo().GetFieldsRecursive();

            return fields.Where(f => XFields.Api.TestAccessibility(f, bindingFlags)).ToList();
        }

        public IEnumerable<MemberInfo> GetMember(Type type, string name, MemberTypes memberType, BindingFlags bindingFlags)
        {

            return type.GetMember(name, bindingFlags).Where(m =>
            {
                if ((m.MemberType() | memberType) != memberType)
                {
                    return false;
                }

                return true;
            });
        }

        public PropertyInfo GetProperty(Type type, string name)
        {
            return type.GetProperty(name, ReflectionStatics.DefaultFlags);
        }

        public PropertyInfo GetProperty(Type type, string name, BindingFlags bindingFlags)
        {
            PropertyInfo property = type.GetTypeInfo().GetDeclaredProperty(name);
            if (property == null || !XProperties.Api.TestAccessibility(property, bindingFlags))
            {
                return null;
            }

            return property;
        }

        public IEnumerable<FieldInfo> GetFields(Type type)
        {
            return type.GetFields(ReflectionStatics.DefaultFlags);
        }

        public MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
        {
            const BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

            switch (memberInfo.MemberType())
            {
                case MemberTypes.Property:
                    PropertyInfo propertyInfo = (PropertyInfo)memberInfo;

                    Type[] types = propertyInfo.GetIndexParameters().Select(p => p.ParameterType).ToArray();

                    return targetType.GetProperty(propertyInfo.Name, bindingAttr, null, propertyInfo.PropertyType, types, null);
                default:
                    return targetType.GetMember(memberInfo.Name, memberInfo.MemberType(), bindingAttr).SingleOrDefault();
            }
        }

        public List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
        {
            List<MemberInfo> targetMembers = new List<MemberInfo>();

            targetMembers.AddRange(GetFields(type, bindingAttr));
            targetMembers.AddRange(GetProperties(type, bindingAttr));

            // for some reason .NET returns multiple members when overriding a generic member on a base class
            // http://social.msdn.microsoft.com/Forums/en-US/b5abbfee-e292-4a64-8907-4e3f0fb90cd9/reflection-overriden-abstract-generic-properties?forum=netfxbcl
            // filter members to only return the override on the topmost class
            // update: I think this is fixed in .NET 3.5 SP1 - leave this in for now...
            List<MemberInfo> distinctMembers = new List<MemberInfo>(targetMembers.Count);

            foreach (IGrouping<string, MemberInfo> groupedMember in targetMembers.GroupBy(m => m.Name))
            {
                int count = groupedMember.Count();

                if (count == 1)
                {
                    distinctMembers.Add(groupedMember.First());
                }
                else
                {
                    IList<MemberInfo> resolvedMembers = new List<MemberInfo>();
                    foreach (MemberInfo memberInfo in groupedMember)
                    {
                        // this is a bit hacky
                        // if the hiding property is hiding a base property and it is virtual
                        // then this ensures the derived property gets used
                        if (resolvedMembers.Count == 0)
                        {
                            resolvedMembers.Add(memberInfo);
                        }
                        else if (!XMembers.Api.IsOverridenGenericMember(memberInfo, bindingAttr) || memberInfo.Name == "Item")
                        {
                            resolvedMembers.Add(memberInfo);
                        }
                    }

                    distinctMembers.AddRange(resolvedMembers);
                }
            }

            return distinctMembers;
        }

        public IList<MemberInfo> GetMembersRecursive(TypeInfo type)
        {
            TypeInfo t = type;
            IList<MemberInfo> members = new List<MemberInfo>();
            while (t != null)
            {
                foreach (MemberInfo member in t.DeclaredMembers)
                {
                    if (!members.Any(p => p.Name == member.Name))
                    {
                        members.Add(member);
                    }
                }
                t = (t.BaseType != null) ? t.BaseType.GetTypeInfo() : null;
            }

            return members;
        }

        public IList<PropertyInfo> GetPropertiesRecursive(TypeInfo type)
        {
            TypeInfo t = type;
            IList<PropertyInfo> properties = new List<PropertyInfo>();
            while (t != null)
            {
                foreach (PropertyInfo member in t.DeclaredProperties)
                {
                    if (!properties.Any(p => p.Name == member.Name))
                    {
                        properties.Add(member);
                    }
                }
                t = (t.BaseType != null) ? t.BaseType.GetTypeInfo() : null;
            }

            return properties;
        }

        public IList<FieldInfo> GetFieldsRecursive(TypeInfo type)
        {
            TypeInfo t = type;
            IList<FieldInfo> fields = new List<FieldInfo>();
            while (t != null)
            {
                foreach (FieldInfo member in t.DeclaredFields)
                {
                    if (!fields.Any(p => p.Name == member.Name))
                    {
                        fields.Add(member);
                    }
                }
                t = (t.BaseType != null) ? t.BaseType.GetTypeInfo() : null;
            }

            return fields;
        }

        

        public MethodInfo GetMethod(Type type, string name)
        {
            return XTypesBasic.Api.GetMethod(type, name);
        }

        public MethodInfo GetMethod(Type type, IList<Type> parameterTypes)
        {
            return GetMethod(type, null, parameterTypes);
        }

        public MethodInfo GetMethod(Type type, string name, IList<Type> parameterTypes)
        {
            return GetMethod(type, name, ReflectionStatics.DefaultFlags, null, parameterTypes, null);
        }

        public MethodInfo GetMethod(Type type, string name, BindingFlags bindingFlags, object placeHolder1, IList<Type> parameterTypes, object placeHolder2)
        {
            return MethodBinder.SelectMethod(type.GetTypeInfo().DeclaredMethods.Where(m => (name == null || m.Name == name) && XMethods.Api.TestAccessibility(m, bindingFlags)), parameterTypes);
        }


        public bool IsGenericTypeDefinition(Type type)
        {
            return XBaseTypes.IsGenericTypeDefinition(type);
        }

        public Type BaseType(Type type)
        {
            return XBaseTypes.BaseType(type);
        }

        public Assembly Assembly(Type type)
        {
            return XBaseTypes.Assembly(type);
        }

        public bool HasDefaultConstructor(Type type, bool nonPublic)
        {
            return XBaseTypes.HasDefaultConstructor(type, nonPublic);
        }

        public bool ContainsGenericParameters(Type type)
        {
            return XBaseTypes.ContainsGenericParameters(type);
        }

        public bool IsGenericType(Type type)
        {
            return XBaseTypes.IsGenericType(type);
        }

        public MemberInfo GetField(Type type, string member)
        {
            return type.GetField(member, ReflectionStatics.DefaultFlags);
        }

        public MemberInfo GetField(Type type, string member, BindingFlags bindingFlags)
        {
            MemberInfo field = type.GetTypeInfo().GetDeclaredField(member);
            if (field == null || !XMembers.Api.TestAccessibility(field, bindingFlags))
            {
                return null;
            }

            return field;
        }

        public IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
        {
            XValidation.ArgumentNotNull(targetType, nameof(targetType));

            List<PropertyInfo> propertyInfos = new List<PropertyInfo>(targetType.GetProperties(bindingAttr));

            // GetProperties on an interface doesn't return properties from its interfaces
            if (XTypesBasic.IsInterface(targetType))
            {
                foreach (Type i in targetType.GetInterfaces())
                {
                    propertyInfos.AddRange(i.GetProperties(bindingAttr));
                }
            }

            XProperties.Api.GetChildPrivateProperties(propertyInfos, targetType, bindingAttr);

            // a base class private getter/setter will be inaccessible unless the property was gotten from the base class
            for (int i = 0; i < propertyInfos.Count; i++)
            {
                PropertyInfo member = propertyInfos[i];
                if (member.DeclaringType != targetType)
                {
                    PropertyInfo declaredMember = (PropertyInfo)GetMemberInfoFromType(member.DeclaringType, member);
                    propertyInfos[i] = declaredMember;
                }
            }

            return propertyInfos;
        }
    }
}
