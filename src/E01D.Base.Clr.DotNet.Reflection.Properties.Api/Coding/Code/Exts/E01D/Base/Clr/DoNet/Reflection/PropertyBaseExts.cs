using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection
{
    public static class PropertyExts
    {
        public static bool IsVirtual(this PropertyInfo propertyInfo)
        {
            return XPropertiesBase.IsVirtual(propertyInfo);
        }

        public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
        {
            return XPropertiesBase.GetBaseDefinition(propertyInfo);
        }

        public static bool IsPublic(this PropertyInfo property)
        {
            return XPropertiesBase.IsPublic(property);
        }

        /// <summary>
        /// Determines whether the property is an indexed property.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <returns>
        /// 	<c>true</c> if the property is an indexed property; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsIndexedProperty(this PropertyInfo property)
        {
            return XPropertiesBase.IsIndexedProperty(property);
        }

        public static MethodInfo GetGetMethod(this PropertyInfo propertyInfo)
        {
            return XPropertiesBase.Api.GetGetMethod(propertyInfo);
        }

        public static MethodInfo GetGetMethod(this PropertyInfo propertyInfo, bool nonPublic)
        {
            return XPropertiesBase.Api.GetGetMethod(propertyInfo, nonPublic);
        }

        public static MethodInfo GetSetMethod(this PropertyInfo propertyInfo)
        {
            return XPropertiesBase.Api.GetSetMethod(propertyInfo);
        }

        public static MethodInfo GetSetMethod(this PropertyInfo propertyInfo, bool nonPublic)
        {
            return XPropertiesBase.Api.GetSetMethod(propertyInfo, nonPublic);
        }
    }
}
