using Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XAttributes
    {
        public static AttributeApi Api { get; set; } = new AttributeApi();

        public static T GetAttribute<T>(object attributeProvider) where T : System.Attribute
        {
            return Api.GetAttribute<T>(attributeProvider);
        }

        public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : System.Attribute
        {
            return Api.GetAttribute<T>(attributeProvider, inherit);
        }


        public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : System.Attribute
        {
            return Api.GetAttributes<T>(attributeProvider, inherit);
        }

        public static System.Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit)
        {
            return Api.GetAttributes(attributeProvider, attributeType, inherit);
        }
    }
}
