using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XProperties
    {
        public static PropertyApi Api { get; set; } = new PropertyApi();

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
    }
}
