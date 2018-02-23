using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Base.Clr.DotNet.Reflection.Types;
using Root.Coding.Code.Models.E01D.Base.Types;
using Root.Coding.Code.Statics.E01D.Base.Clr.DotNet.Reflection.Types;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection
{
    public class TypeBasicApi
    {
        public Assembly Assembly(Type type)
        {
            return type.Assembly;
        }

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match)
        {
            Type current = type;

            while (current != null)
            {
                if (string.Equals(current.FullName, fullTypeName, StringComparison.Ordinal))
                {
                    match = current;
                    return true;
                }

                current = current.BaseType();
            }

            if (searchInterfaces)
            {
                foreach (Type i in type.GetInterfaces())
                {
                    if (string.Equals(i.Name, fullTypeName, StringComparison.Ordinal))
                    {
                        match = type;
                        return true;
                    }
                }
            }

            match = null;
            return false;
        }

        public bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces)
        {
            Type match;

            return type.AssignableToTypeName(fullTypeName, searchInterfaces, out match);
        }

        

        public Type BaseType(Type type)
        { 
            return type.BaseType;
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject)
        {
            if (targetObject == null) return new PropertyValue[] { };

            var methods = GetAllGetAccessors(targetObject.GetType());

            var values = GetAllPropertyValues(targetObject, methods);

            return values;
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject, Type type)
        {
            if (targetObject == null) return new PropertyValue[] { };

            var methods = GetAllGetAccessors(type);

            var values = GetAllPropertyValues(targetObject, methods);

            return values;
        }

        public PropertyValue[] GetAllPropertyValues(object targetObject, GetAccessor[] allGetAccessors)
        {
            if (targetObject == null) return new PropertyValue[] { };



            PropertyValue[] propertyValues = new PropertyValue[allGetAccessors.Length];

            for (int i = 0; i < allGetAccessors.Length; i++)
            {
                var getAccessor = allGetAccessors[i];

                var propertyValue = getAccessor.MethodBase.Invoke(targetObject, null);

                propertyValues[i] = new PropertyValue()
                {
                    Value = propertyValue,
                    PropertyType = getAccessor.ReturnType

                };
            }

            return propertyValues;
        }

        public GetAccessor[] GetAllGetAccessors(Type type)
        {
            Dictionary<RuntimeMethodHandle, GetAccessor> propertyTable = new Dictionary<RuntimeMethodHandle, GetAccessor>();

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < properties.Length; i++)
            {
                var property = properties[i];

                var method = property.GetGetMethod();

                GetAccessor getAccessor = new GetAccessor()
                {
                    MethodBase = method,
                    ReturnType = property.PropertyType
                };

                if (!propertyTable.ContainsKey(method.MethodHandle))
                {
                    propertyTable.Add(method.MethodHandle, getAccessor);
                }
            }

            var interfaces = type.GetInterfaces();

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < interfaces.Length; i++)
            {
                var interfaceDeclaration = interfaces[i];

                properties = interfaceDeclaration.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                // ReSharper disable once ForCanBeConvertedToForeach
                for (var j = 0; j < properties.Length; j++)
                {
                    var property = properties[j];

                    var method = property.GetGetMethod(true);

                    if (!propertyTable.ContainsKey(method.MethodHandle))
                    {
                        GetAccessor getAccessor = new GetAccessor()
                        {
                            MethodBase = method,
                            ReturnType = property.PropertyType
                        };

                        propertyTable.Add(method.MethodHandle, getAccessor);

                    }
                }
            }

            return propertyTable.Values.ToArray();
        }





        public MethodInfo GetMethod(Type type, string name)
        {
            return type.GetMethod(name);
        }


        public Type GetObjectType(object v)
        {
            return v?.GetType();
        }

        
        

        public bool HasDefaultConstructor(Type t, bool nonPublic)
        {
            XValidation.ArgumentNotNull(t, nameof(t));

            if (t.IsValueType())
            {
                return true;
            }

            return (GetDefaultConstructor(t, nonPublic) != null);
        }

        

        public ConstructorInfo GetDefaultConstructor(Type t)
        {
            return GetDefaultConstructor(t, false);
        }

        public ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
        {
            BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
            if (nonPublic)
            {
                bindingFlags = bindingFlags | BindingFlags.NonPublic;
            }

            return t.GetConstructors(bindingFlags).SingleOrDefault(c => !c.GetParameters().Any());
        }

        

        


        

        

        

        

        

        public bool IsAbstract(Type type)
        {
            return type.IsAbstract;
        }

        /// <summary>
        /// Gets whether the specified type is an array.
        /// </summary>
        public bool IsArray(Type type)
        {
            return type.IsArray;
        }

        public bool IsAttribute(Type type)
        {
            return type.IsSubclassOf(WellknownSystemTypes.AttributeType);
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

        public bool IsDefined(Type type, Type attributeType, bool inherit)
        {
            return type.GetTypeInfo().CustomAttributes.Any(a => a.AttributeType == attributeType);
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

        public bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
        {
            if (!type.IsGenericType())
            {
                return false;
            }

            Type t = type.GetGenericTypeDefinition();
            return (t == genericInterfaceDefinition);
        }

        public bool IsGenericTypeDefinition(Type type)
        {
            return type.IsGenericTypeDefinition;
        }

        public bool IsGenericType(Type type)
        {
            return type.IsGenericType;
        }

        public bool ContainsGenericParameters(Type type)
        {
            return type.ContainsGenericParameters;
        }

        



        

        

        

        

        public bool IsSealed(Type type)
        {
#if HAVE_FULL_REFLECTION
            return type.IsSealed;
#else
            return type.GetTypeInfo().IsSealed;
#endif
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

        public bool IsNullable(Type t)
        {
            XValidation.ArgumentNotNull(t, nameof(t));

            if (t.IsValueType())
            {
                return IsNullableType(t);
            }

            return true;
        }

        public bool IsNullableType(Type t)
        {
            XValidation.ArgumentNotNull(t, nameof(t));

            return (t.IsGenericType() && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        /// <summary>
        /// Gets whether the specified type is a pointer
        /// </summary>
        public bool IsPointer(Type type)
        {
            return type.IsPointer;
        }

        public bool IsPrimitive(Type type)
        {
            return type.IsPrimitive;
        }

        /// <summary>
        /// Gets whether the specified type is a valuetype
        /// </summary>
        public bool IsValueType(Type type)
        {
            return type.IsValueType;
        }

        public bool IsVisible(Type type)
        {
            return type.IsVisible;
        }

        

     

        

        

        


        

        public IEnumerable<MethodInfo> GetMethods(Type type, BindingFlags bindingFlags)
        {
            return type.GetTypeInfo().DeclaredMethods;
        }

        

        

        public Type[] GetGenericArguments(Type type)
        {
            return type.GetTypeInfo().GenericTypeArguments;
        }

        public IEnumerable<Type> GetInterfaces(Type type)
        {
            return type.GetTypeInfo().ImplementedInterfaces;
        }

        public IEnumerable<MethodInfo> GetMethods(Type type)
        {
            return type.GetTypeInfo().DeclaredMethods;
        }

        public bool IsSubclassOf(Type type, Type c)
        {
            return type.GetTypeInfo().IsSubclassOf(c);
        }

        public bool IsAssignableFrom(Type type, Type c)
        {
            return type.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
        }


        public bool IsInstanceOfType(Type type, object o)
        {
            if (o == null)
            {
                return false;
            }

            return type.IsInstanceOfType(o);
        }



    }
}
