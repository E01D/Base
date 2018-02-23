using System;
using System.Collections.Generic;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DotNet.Reflection.Types
{
    public static class BasicTypeExts
    {
        public static System.Reflection.Assembly Assembly(this System.Type type)
        {
            return XTypesBasic.Assembly(type);
        }

        public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return XTypesBasic.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
        {
            return XTypesBasic.AssignableToTypeName(type, fullTypeName, searchInterfaces);
        }

        public static System.Type BaseType(this System.Type type)
        {
            return XTypesBasic.BaseType(type);
        }

        public static bool IsAbstract(this System.Type type)
        {
            return XTypesBasic.IsAbstract(type);
        }

        public static bool IsClass(this System.Type type)
        {
            return XTypesBasic.IsClass(type);
        }

        public static bool IsDefined(this Type type, Type attributeType, bool inherit)
        {
            return XTypesBasic.IsDefined(type, attributeType, inherit);
        }

        public static bool IsDelegate(this Type type)
        {
            return XTypesBasic.IsDelegate(type);
        }

        

        public static bool IsGenericDefinition(this System.Type type, System.Type genericInterfaceDefinition)
        {
            return XTypesBasic.IsGenericDefinition(type, genericInterfaceDefinition);
        }

        public static bool IsGenericTypeDefinition(this System.Type type)
        {
            return XTypesBasic.IsGenericTypeDefinition(type);
        }

        public static bool IsGenericType(this System.Type t)
        {
            return XTypesBasic.IsGenericType(t);
        }

        public static bool IsInterface(this System.Type type)
        {
            return XTypesBasic.IsInterface(type);
        }

        public static bool IsEnum(this System.Type type)
        {
            return XTypesBasic.IsEnum(type);
        }

        public static bool IsNullable(this System.Type t)
        {
            return XTypesBasic.IsNullable(t);
        }

        public static bool IsNullableType(this System.Type t)
        {
            return XTypesBasic.IsNullableType(t);
        }

        public static bool IsValueType(this System.Type t)
        {
            return XTypesBasic.IsValueType(t);
        }

        public static bool IsPrimitive(this System.Type t)
        {
            return XTypesBasic.IsPrimitive(t);
        }

        public static Type[] GetGenericArguments(this Type type)
        {
            return XTypesBasic.Api.GetGenericArguments(type);
        }

        public static IEnumerable<Type> GetInterfaces(this Type type)
        {
            return XTypesBasic.Api.GetInterfaces(type);
        }

        public static IEnumerable<MethodInfo> GetMethods(this Type type)
        {
            return XTypesBasic.Api.GetMethods(type);
        }

        public static bool IsSubclassOf(this Type type, Type c)
        {
            return XTypesBasic.Api.IsSubclassOf(type, c);
        }

        public static  bool IsAssignableFrom(this Type type, Type c)
        {
            return XTypesBasic.Api.IsAssignableFrom(type, c);
        }


        public static bool IsInstanceOfType(this Type type, object o)
        {
            return XTypesBasic.Api.IsInstanceOfType(type, o);
        }

    }
}
