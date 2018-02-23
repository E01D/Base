using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XTypesBasic
    {
        public static TypeBasicApi Api { get; set; } = new TypeBasicApi();

        public static Assembly Assembly(Type type)
        {
            return Api.Assembly(type);
        }

        public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return Api.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces)
        {
            return Api.AssignableToTypeName(type, fullTypeName, searchInterfaces);
        }

        public static Type BaseType(Type type)
        {
            return Api.BaseType(type);
        }

       

        public static GetAccessor[] GetAllGetAccessors(Type type)
        {
            return Api.GetAllGetAccessors(type);
        }

        public static PropertyValue[] GetAllPropertyValues(object targetObject)
        {
            return Api.GetAllPropertyValues(targetObject);
        }

        public static PropertyValue[] GetAllPropertyValues(object targetObject, Type type)
        {
            return Api.GetAllPropertyValues(targetObject, type);
        }

        public static PropertyValue[] GetAllPropetyValues(object targetObject, GetAccessor[] allGetAccessors)
        {
            return Api.GetAllPropertyValues(targetObject, allGetAccessors);
        }

        public static Type GetObjectType(object v)
        {
            return Api.GetObjectType(v);
        }

        

        

        public static ConstructorInfo GetDefaultConstructor(Type t)
        {
            return Api.GetDefaultConstructor(t);
        }

        public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
        {
            return Api.GetDefaultConstructor(t, nonPublic);
        }

        

        public static bool HasDefaultConstructor(Type t, bool nonPublic)
        {
            return Api.HasDefaultConstructor(t, nonPublic);
        }

        public static bool IsAbstract(Type type)
        {
            return Api.IsAbstract(type);
        }

        public static bool IsArray(Type type)
        {
            return Api.IsArray(type);
        }

        public static bool IsAttribute(Type type)
        {
            return Api.IsAttribute(type);
        }

        public static bool IsClass(System.Type type)
        {
            return Api.IsClass(type);
        }

        public static bool IsDefined(Type type, Type attributeType, bool inherit)
        {
            return Api.IsDefined(type, attributeType, inherit);
        }

        public static bool IsDelegate(Type type)
        {
            return Api.IsDelegate(type);
        }

        

        public static bool IsEnum(Type type)
        {
            return Api.IsEnum(type);
        }

        public static bool IsInterface(System.Type type)
        {
            return Api.IsInterface(type);
        }

        public static bool IsPointer(Type type)
        {
            return Api.IsPointer(type);
        }

        public static bool IsPrimitive(Type type)
        {
            return Api.IsPrimitive(type);
        }

        public static bool IsSealed(Type type)
        {
            return Api.IsSealed(type);
        }

        

        

        public static bool IsValueType(Type type)
        {
            return Api.IsValueType(type);
        }

        public static bool IsVisible(Type type)
        {
            return Api.IsVisible(type);
        }


        public static bool IsNullable(Type type)
        {
            return Api.IsNullable(type);
        }

        public static bool IsNullableType(Type type)
        {
            return Api.IsNullable(type);
        }

        public static bool IsGenericType(Type type)
        {
            return Api.IsGenericType(type);
        }

        public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
        {
            return Api.IsGenericDefinition(type, genericInterfaceDefinition);
        }

        public static bool IsGenericTypeDefinition(Type type)
        {
            return Api.IsGenericTypeDefinition(type);
        }


        

        public static IEnumerable<MethodInfo> GetMethods(this Type type, BindingFlags bindingFlags)
        {
            return Api.GetMethods(type);
        }

        

        

        public static bool ContainsGenericParameters(Type type)
        {
            return Api.ContainsGenericParameters(type);
        }
    }
}
