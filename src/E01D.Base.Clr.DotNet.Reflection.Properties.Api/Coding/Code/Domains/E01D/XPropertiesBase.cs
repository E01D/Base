using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XPropertiesBase
    {
        public static PropertyBaseApi Api { get; set; } = new PropertyBaseApi();

        public static bool IsVirtual(PropertyInfo propertyInfo)
        {
            return Api.IsVirtual(propertyInfo);
        }

        public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo)
        {
            return Api.GetBaseDefinition(propertyInfo);
        }

        public static bool IsPublic(PropertyInfo property)
        {
            return Api.IsPublic(property);
        }

        /// <summary>
        /// Determines whether the property is an indexed property.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <returns>
        /// 	<c>true</c> if the property is an indexed property; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsIndexedProperty(PropertyInfo property)
        {
            return Api.IsIndexedProperty(property);
        }
    }
}
