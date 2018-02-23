using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Types;
using Root.Coding.Code.Statics.E01D.Base.Clr.DotNet.Reflection;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XTypes
    {
        public static TypeApi Api { get; set; } = new TypeApi();

        public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            return Api.AssignableToTypeName(type, fullTypeName, searchInterfaces, out match);
        }

        public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterface)
        {
            return Api.AssignableToTypeName(type, fullTypeName, searchInterface);
        }

        public static ConstructorInfo GetConstructor(this Type type, IList<Type> parameterTypes)
        {
            return Api.GetConstructor(type, parameterTypes);
        }

        public static ConstructorInfo GetConstructor(this Type type, BindingFlags bindingFlags, object placeholder1,
            IList<Type> parameterTypes, object placeholder2)
        {
            return Api.GetConstructor(type, bindingFlags, placeholder1, parameterTypes, placeholder2);
        }


        public static object[] GetCustomAttributes(System.Type type)
        {
            return Api.GetCustomAttributes(type);
        }

        public static object[] GetCustomAttributes(System.Type type, bool inherit)
        {
            return Api.GetCustomAttributes(type, inherit);
        }

        public static object[] GetCustomAttributes(System.Type type, System.Type attributeType)
        {
            return Api.GetCustomAttributes(type, attributeType, false);
        }

        public static object[] GetCustomAttributes(System.Type type, System.Type attributeType, bool inherit)
        {
            return Api.GetCustomAttributes(type, attributeType, inherit);
        }

        public static RuntimeTypeHandle GetTypeHandle(TypeId_I zTypeId)
        {
            return Api.GetTypeHandle(zTypeId);
        }


        public static TypeId_I GetTypeId<T>()
        {
            return Api.GetTypeId<T>();
        }

        

        public static TypeId_I GetTypeId(Type type)
        {
            return Api.GetTypeId(type);
        }

        public static TypeId_I GetTypeId(RuntimeTypeHandle handle)
        {
            return Api.GetTypeId(handle);
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

        public static bool IsDelegate(Type type)
        {
            return Api.IsDelegate(type);
        }

        public static bool IsDictionaryType(Type type)
        {
            return Api.IsDicitonaryType(type);
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


        public static bool ImplementInterface(Type type, Type interfaceType)
        {
            return Api.ImplementInterface(type, interfaceType);
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

        public static bool HasDefaultConstructor(Type type, bool nonPublic)
        {
            return Api.HasDefaultConstructor(type, nonPublic);
        }

        

        public static bool ContainsGenericParameters(Type type)
        {
            return Api.ContainsGenericParameters(type);
        }

        public static bool IsGenericType(Type type)
        {
            return Api.IsGenericType(type);
        }

        public static MethodInfo GetMethod(Type type, string name)
        {
            return Api.GetMethod(type, name);
        }

        public static MethodInfo GetMethod(Type type, string name, BindingFlags bindingFlags)
        {
            return GetMethod(type, name, bindingFlags);
        }

        public static MethodInfo GetMethod(Type type, IList<Type> parameterTypes)
        {
            return Api.GetMethod(null, parameterTypes);
        }

        public static MethodInfo GetMethod(Type type, string name, IList<Type> parameterTypes)
        {
            
            return Api.GetMethod(type, name, parameterTypes);
        }

        public static MethodInfo GetMethod(Type type, string name, BindingFlags bindingFlags, object placeHolder1, IList<Type> parameterTypes, object placeHolder2)
        {
            return Api.GetMethod(type, name, bindingFlags, placeHolder1, parameterTypes, placeHolder2);
        }

        

        public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
        {
            return Api.GetConstructors(type);
        }

        public static IEnumerable<ConstructorInfo> GetConstructors(Type type, BindingFlags bindingFlags)
        {
            return Api.GetConstructors(type, bindingFlags);
        }

        public static IList<MemberInfo> GetMembersRecursive(TypeInfo type)
        {
            return Api.GetMembersRecursive(type);
        }

        public static IList<PropertyInfo> GetPropertiesRecursive(TypeInfo type)
        {
            return Api.GetPropertiesRecursive(type);
        }


        public static IList<FieldInfo> GetFieldsRecursive(TypeInfo type)
        {
            return Api.GetFieldsRecursive(type);
        }

        
    }
}

//public static TypeLoaderApi_I TypeLoader => Api.TypeLoader;

//public static void ScanAssembly(SymbolLibrary context, Assembly assembly)
//{
//    Api.Scanning.Assemblies.ScanAssembly(context, assembly);
//}

//public static void ScanMember(SymbolLibrary context, System.Reflection.MemberInfo memberInfo)
//{
//    //Api.Scanning.Members.ScanMember(context, memberInfo);
//}

//public static void ScanEntryAssemblyDirectoryForAssemblies(SymbolLibrary context)
//{
//    Api.Scanning.IO.ScanEntryAssemblyDirectoryForAssemblies(context);
//}

//public static void ScanDirectoryForAssemblies(SymbolLibrary context, DirectoryPath directory)
//{
//    Api.Scanning.IO.ScanDirectoryForAssemblies(context, directory);
//}

//public static void ScanType(SymbolLibrary context, Type type)
//{
//    Api.Scanning.Types.ScanType(context, type);
//}

////public static TypeInfo_I GetTypeInfo(TypalContext_I context, object objectReference)
////{
////    return Api.GetTypeInfo(context, objectReference);
////}
//public static List<ClassSymbol> GetImplementingClasses(System.Type type)
//{
//    return Api.Library.GetImplementingClasses(type);
//}

//public static Typa_I GetTypa(Type type)
//{
//    return Api.Library.GetTypa(type);
//}

//public static void Initialize()
//{
//    Api.Initialize();
//}

//public static void EnsureTypasAreStored()
//{
//    Api.EnsureTypasAreStored();
//}

//public static List<AttributedClassSymbol> GetAttributedClasses(Type dataApiAttributeType)
//{
//    return Api.Library.GetAttributedClasses(dataApiAttributeType);
//}

//public static long GetTypaId<T>()
//{
//    throw new NotImplementedException();
//}