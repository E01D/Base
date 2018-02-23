using System;
using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Serialization;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal.Scanning;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Reflection;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet
{
    public class ReflectionApi
    {
        public AssemblyApi Assemblies => XAssemblies.Api;

        public ReflectionIOApi IO => XReflectionIO.Api;

        public MemberApi Members => XMembers.Api;

        public MethodApi Methods => XMethods.Api;

        public PropertyApi Properties => XProperties.Api;

        public ScanningApi Scanning => XReflectionScanning.Api;

        public TypeApi Types => XTypes.Api;

        

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return XTypes.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces)
        {
            return XTypes.AssignableToTypeName(type, fullTypeName, searchInterfaces);
        }

        public MethodInfo GetBaseDefinition(PropertyInfo propertyInfo)
        {
            return Properties.GetBaseDefinition(propertyInfo);
        }

        public string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder)
        {
            return Types.GetFullyQualifiedTypeName(t, binder);
        }

        public Type GetObjectType(object v)
        {
            return Types.GetObjectType(v);
        }

        public string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder)
        {
            return Types.GetTypeName(t, assemblyFormat, binder);
        }

        

        public bool ImplementInterface(Type type, Type interfaceType)
        {
            return XTypes.ImplementInterface(type, interfaceType);
        }


        

        public bool IsAbstract(Type type)
        {
            return XTypes.IsAbstract(type);
        }

        public bool IsEnum(Type type)
        {
            return XTypes.IsEnum(type);
        }

        public bool IsClass(Type type)
        {
            return XTypes.IsClass(type);
        }

        public bool IsDictionaryType(Type type)
        {
            return XTypes.IsDictionaryType(type);
        }

        public bool IsPrimitive(Type type)
        {
            return XTypes.IsPrimitive(type);
        }

        public bool IsPublic(PropertyInfo property)
        {
            return Properties.IsPublic(property);
        }

        public bool IsSealed(Type type)
        {
            return XTypes.IsSealed(type);
        }

        public bool IsVisible(Type type)
        {
            return XTypes.IsVisible(type);
        }

        public bool IsValueType(Type type)
        {
            return XTypes.IsValueType(type);
        }

        public bool IsVirtual(PropertyInfo propertyInfo)
        {
            return Properties.IsPublic(propertyInfo);
        }

        public string RemoveAssemblyDetails(string fullyQualifiedTypeName)
        {
            return Types.RemoveAssemblyDetails(fullyQualifiedTypeName);
        }

        /// <summary>
        /// Gets the member's underlying type.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>The underlying type of the member.</returns>
        public Type GetMemberUnderlyingType(MemberInfo member)
        {
            return Members.GetMemberUnderlyingType(member);
        }

        /// <summary>
        /// Determines whether the member is an indexed property.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>
        /// 	<c>true</c> if the member is an indexed property; otherwise, <c>false</c>.
        /// </returns>
        public bool IsIndexedProperty(MemberInfo member)
        {
            return Members.IsIndexedProperty(member);
        }

        

        /// <summary>
        /// Gets the member's value on the object.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="target">The target object.</param>
        /// <returns>The member's value on the object.</returns>
        public object GetMemberValue(MemberInfo member, object target)
        {
            return Members.GetMemberValue(member, target);
        }

        /// <summary>
        /// Sets the member's value on the target object.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="target">The target.</param>
        /// <param name="value">The value.</param>
        public void SetMemberValue(MemberInfo member, object target, object value)
        {
            Members.SetMemberValue(member, target, value);
        }

        /// <summary>
        /// Determines whether the specified MemberInfo can be read.
        /// </summary>
        /// <param name="member">The MemberInfo to determine whether can be read.</param>
        /// /// <param name="nonPublic">if set to <c>true</c> then allow the member to be gotten non-publicly.</param>
        /// <returns>
        /// 	<c>true</c> if the specified MemberInfo can be read; otherwise, <c>false</c>.
        /// </returns>
        public bool CanReadMemberValue(MemberInfo member, bool nonPublic)
        {
            return Members.CanReadMemberValue(member, nonPublic);
        }

        /// <summary>
        /// Determines whether the specified MemberInfo can be set.
        /// </summary>
        /// <param name="member">The MemberInfo to determine whether can be set.</param>
        /// <param name="nonPublic">if set to <c>true</c> then allow the member to be set non-publicly.</param>
        /// <param name="canSetReadOnly">if set to <c>true</c> then allow the member to be set if read-only.</param>
        /// <returns>
        /// 	<c>true</c> if the specified MemberInfo can be set; otherwise, <c>false</c>.
        /// </returns>
        public bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
        {
            return Members.CanSetMemberValue(member, nonPublic, canSetReadOnly);
        }

        

        public bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
        {
            return Members.IsOverridenGenericMember(memberInfo, bindingAttr);
        }

        

        

        public BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag)
        {
            return ((bindingAttr & flag) == flag)
                ? bindingAttr ^ flag
                : bindingAttr;
        }

        

        

        


        


        


        public bool HasDefaultConstructor(Type type, bool nonPublic)
        {
            return XTypes.HasDefaultConstructor(type, nonPublic);
        }

        public MethodInfo Method(Delegate @delegate)
        {
            return XMethods.Api.Method(@delegate);
        }

        public MemberTypes MemberType(MemberInfo memberInfo)
        {
            return XMembers.MemberType(memberInfo);
        }

        public bool ContainsGenericParameters(Type type)
        {
            return XTypes.ContainsGenericParameters(type);
        }

        public bool IsGenericType(Type type)
        {
            return XTypes.IsGenericType(type);
        }

        public bool IsInterface(Type type)
        {
            return XTypes.IsInterface(type);
        }

        

        public bool IsGenericTypeDefinition(Type type)
        {
            return XTypes.IsGenericTypeDefinition(type);
        }

        public Type BaseType(Type type)
        {
            return XTypes.BaseType(type);
        }

        public Assembly Assembly(Type type)
        {
            return XTypes.Assembly(type);
        }

        public static bool IsNonSerializable(object provider)
        {
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            //#if HAVE_FULL_REFLECTION
            //            return (GetCachedAttribute<NonSerializedAttribute>(provider) != null);
            //#else
            //            FieldInfo fieldInfo = provider as FieldInfo;
            //            if (fieldInfo != null && (fieldInfo.Attributes & FieldAttributes.NotSerialized) == FieldAttributes.NotSerialized)
            //            {
            //                return true;
            //            }

            //            return false;
            //#endif
        }


        public static bool IsSerializable(object provider)
        {
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            //#if HAVE_FULL_REFLECTION
            //            return (GetCachedAttribute<SerializableAttribute>(provider) != null);
            //#else
            //            Type type = provider as Type;
            //            if (type != null && (type.GetTypeInfo().Attributes & TypeAttributes.Serializable) == TypeAttributes.Serializable)
            //            {
            //                return true;
            //            }

            //            return false;
            //#endif
        }


        //public T GetAttribute<T>(object provider) where T : Attribute
        //{
        //    Type type = provider as Type;
        //    if (type != null)
        //    {
        //        return GetAttribute<T>(type);
        //    }

        //    MemberInfo memberInfo = provider as MemberInfo;
        //    if (memberInfo != null)
        //    {
        //        return GetAttribute<T>(memberInfo);
        //    }

        //    return XReflection.Api.GetAttribute<T>(provider, true);
        //}

#if DEBUG
        public void SetFullyTrusted(bool? fullyTrusted)
        {
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            //_fullyTrusted = fullyTrusted;
        }

        public void SetDynamicCodeGeneration(bool dynamicCodeGeneration)
        {
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            //_dynamicCodeGeneration = dynamicCodeGeneration;
        }
#endif

        public bool DynamicCodeGeneration
        {
            get
            {
                throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            }
            //#if HAVE_SECURITY_SAFE_CRITICAL_ATTRIBUTE
            //            [SecuritySafeCritical]
            //#endif
            //            get
            //            {
            //                if (_dynamicCodeGeneration == null)
            //                {
            //#if HAVE_CAS
            //                    try
            //                    {
            //                        new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
            //                        new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
            //                        new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
            //                        new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
            //                        new SecurityPermission(PermissionState.Unrestricted).Demand();
            //                        _dynamicCodeGeneration = true;
            //                    }
            //                    catch (Exception)
            //                    {
            //                        _dynamicCodeGeneration = false;
            //                    }
            //#else
            //                    _dynamicCodeGeneration = false;
            //#endif
            //                }

            //                return _dynamicCodeGeneration.GetValueOrDefault();
            //            }
        }

        public static bool FullyTrusted
        {
            get
            {
                throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
                //                if (_fullyTrusted == null)
                //                {
                //#if (DOTNET || PORTABLE || PORTABLE40)
                //                    _fullyTrusted = true;
                //#elif !(NET20 || NET35 || PORTABLE40)
                //                    AppDomain appDomain = AppDomain.CurrentDomain;

                //                    _fullyTrusted = appDomain.IsHomogenous && appDomain.IsFullyTrusted;
                //#else
                //                    try
                //                    {
                //                        new SecurityPermission(PermissionState.Unrestricted).Demand();
                //                        _fullyTrusted = true;
                //                    }
                //                    catch (Exception)
                //                    {
                //                        _fullyTrusted = false;
                //                    }
                //#endif
                //                }

                //                return _fullyTrusted.GetValueOrDefault();
            }
        }

        //public ReflectionDelegateFactory ReflectionDelegateFactory
        //{
        //    get
        //    {
        //        throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
        //        //#if !(PORTABLE40 || PORTABLE || DOTNET || NETSTANDARD2_0)
        //        //                if (DynamicCodeGeneration)
        //        //                {
        //        //                    return DynamicReflectionDelegateFactory.Instance;
        //        //                }

        //        //                return LateBoundReflectionDelegateFactory.Instance;
        //        //#else
        //        //                return ExpressionReflectionDelegateFactory.Instance;
        //        //#endif
        //    }
        //}

        //public DelegateFactoryApi DelegateFactories { get; set; }

#if DOTNET || PORTABLE
#if !DOTNET
        

        
#endif

        public bool IsSubclassOf(this Type type, Type c)
        {
            return type.GetTypeInfo().IsSubclassOf(c);
        }

#if !DOTNET
        public bool IsAssignableFrom(this Type type, Type c)
        {
            return type.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
        }
#endif

        public bool IsInstanceOfType(this Type type, object o)
        {
            if (o == null)
            {
                return false;
            }

            return type.IsAssignableFrom(o.GetType());
        }
#endif







#if (PORTABLE40 || DOTNET || PORTABLE)
        public static PropertyInfo GetProperty(this Type type, string name, BindingFlags bindingFlags, object placeholder1, Type propertyType, IList<Type> indexParameters, object placeholder2)
        {
            IEnumerable<PropertyInfo> propertyInfos = type.GetProperties(bindingFlags);

            return propertyInfos.Where(p =>
            {
                if (name != null && name != p.Name)
                {
                    return false;
                }
                if (propertyType != null && propertyType != p.PropertyType)
                {
                    return false;
                }
                if (indexParameters != null)
                {
                    if (!p.GetIndexParameters().Select(ip => ip.ParameterType).SequenceEqual(indexParameters))
                    {
                        return false;
                    }
                }

                return true;
            }).SingleOrDefault();
        }

        public static IEnumerable<MemberInfo> GetMember(this Type type, string name, MemberTypes memberType, BindingFlags bindingFlags)
        {
#if PORTABLE
            return type.GetMemberInternal(name, memberType, bindingFlags);
#else
            return type.GetMember(name, bindingFlags).Where(m =>
            {
                if ((m.MemberType() | memberType) != memberType)
                {
                    return false;
                }

                return true;
            });
#endif
        }
#endif
    }
}
