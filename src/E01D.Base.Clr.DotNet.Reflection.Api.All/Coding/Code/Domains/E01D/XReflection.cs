using System;
using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XReflection
    {
        public static ReflectionApi Api { get; set; } = new ReflectionApi();

        public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return Api.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces)
        {
            return Api.AssignableToTypeName(type, fullTypeName, searchInterfaces);
        }

        public static bool DynamicCodeGeneration()
        {
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            //return Api.DynamicCodeGeneration();
        }

        public static bool ImplementInterface(Type type, Type interfaceType)
        {
            return Api.ImplementInterface(type, interfaceType);
        }

        public static bool IsEnum(System.Type type)
        {
            return Api.IsEnum(type);
        }

        public static bool IsClass(System.Type type)
        {
            return Api.IsClass(type);
        }

        public static bool IsSealed(System.Type type)
        {
            return Api.IsSealed(type);
        }

        public static bool IsAbstract(System.Type type)
        {
            return Api.IsAbstract(type);
        }

        public static bool IsVisible(System.Type type)
        {
            return Api.IsVisible(type);
        }

        public static bool IsValueType(System.Type type)
        {
            return Api.IsValueType(type);
        }

        public static bool IsPrimitive(System.Type type)
        {
            return Api.IsPrimitive(type);
        }

        public static bool HasDefaultConstructor(System.Type t, bool nonPublic)
        {
            return Api.HasDefaultConstructor(t, nonPublic);
        }

        public static MethodInfo Method(Delegate d)
        {
            return Api.Method(d);
        }

        public static MemberTypes MemberType(MemberInfo memberInfo)
        {
            return Api.MemberType(memberInfo);
        }

        public static bool ContainsGenericParameters(Type type)
        {
            return Api.ContainsGenericParameters(type);
        }

        public static bool IsInterface(Type type)
        {
            return Api.IsInterface(type);
        }

        public static bool IsGenericType(Type type)
        {
            return Api.IsGenericType(type);
        }

        public static bool IsGenericTypeDefinition(Type type)
        {
            return Api.IsGenericTypeDefinition(type);
        }

        public static Type BaseType(Type type)
        {
            return Api.BaseType(type);
        }

        public static Assembly Assembly(Type type)
        {
            return Api.Assembly(type);
        }
    }
}
