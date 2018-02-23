using System;
using System.Collections.Generic;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DotNet.Reflection.Types
{
    public static class BasicTypeExts
    {
        public static ConstructorInfo GetConstructor(this Type type, IList<Type> parameterTypes)
        {
            return XTypes.Api.GetConstructor(type, parameterTypes);
        }

        public static ConstructorInfo GetConstructor(this Type type, BindingFlags bindingFlags, object placeholder1, IList<Type> parameterTypes, object placeholder2)
        {
            return XTypes.Api.GetConstructor(type, bindingFlags, placeholder1, parameterTypes, placeholder2);
        }

        public static IEnumerable<ConstructorInfo> GetConstructors(this Type type)
        {
            return XTypes.Api.GetConstructors(type);
        }

        public static IEnumerable<ConstructorInfo> GetConstructors(this Type type, BindingFlags bindingFlags)
        {
            return XTypes.Api.GetConstructors(type, bindingFlags);
        }

        public static MethodInfo GetMethod(this Type type, string name)
        {
            return XTypes.Api.GetMethod(type, name);
        }

        public static MethodInfo GetMethod(this Type type, IList<Type> parameterTypes)
        {
            return XTypes.Api.GetMethod(null, parameterTypes);
        }

        public static MethodInfo GetMethod(this Type type, string name, IList<Type> parameterTypes)
        {
            return XTypes.Api.GetMethod(type, name, parameterTypes);
        }

        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingFlags, object placeHolder1, IList<Type> parameterTypes, object placeHolder2)
        {
            return XTypes.Api.GetMethod(type, name, bindingFlags, placeHolder1, parameterTypes, placeHolder2);
        }

        public static MemberInfo GetField(this Type type, string member)
        {
            return XTypes.Api.GetField(type, member);
        }

        public static MemberInfo GetField(this Type type, string member, BindingFlags bindingFlags)
        {
            return XTypes.Api.GetField(type, member, bindingFlags);
        }

        public static IEnumerable<FieldInfo> GetFields(this Type type)
        {
            return XTypes.Api.GetFields(type);
        }

        public static MemberInfo[] GetMember(this Type type, string member)
        {
            return XTypes.Api.GetMember(type, member);
        }

        public static MemberInfo[] GetMember(this Type type, string member, BindingFlags bindingFlags)
        {
            return XTypes.Api.GetMember(type, member, bindingFlags);
        }

        public static MemberInfo[] GetMemberInternal(this Type type, string member, MemberTypes? memberType, BindingFlags bindingFlags)
        {
            return XTypes.Api.GetMemberInternal(type, member, memberType, bindingFlags);
        }

        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingFlags)
        {
            // BUG - ignores bnding flags
            return XTypes.Api.GetMethod(type, name);
        }

        public static IEnumerable<PropertyInfo> GetProperties(this Type type, BindingFlags bindingFlags)
        {
            return XTypes.Api.GetProperties(type, bindingFlags);
        }

        public static PropertyInfo GetProperty(this Type type, string name)
        {
            return XTypes.Api.GetProperty(type, name);
        }

        public static PropertyInfo GetProperty(this Type type, string name, BindingFlags bindingFlags)
        {
            return XTypes.Api.GetProperty(type, name, bindingFlags);
        }

        public static IList<MemberInfo> GetMembersRecursive(this TypeInfo type)
        {
            return XTypes.Api.GetMembersRecursive(type);
        }

        public static IList<PropertyInfo> GetPropertiesRecursive(this TypeInfo type)
        {
            return XTypes.Api.GetPropertiesRecursive(type);
        }

        public static IList<FieldInfo> GetFieldsRecursive(this TypeInfo type)
        {
            return XTypes.Api.GetFieldsRecursive(type);
        }







    }
}
