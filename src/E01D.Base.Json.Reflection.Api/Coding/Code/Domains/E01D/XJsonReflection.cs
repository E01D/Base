using Root.Coding.Code.Api.E01D.Json;
using Root.Coding.Code.Attributes.E01D.Json.Reflection;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XJsonReflection
    {
        public static JsonReflectionApi Api { get; set; } = new JsonReflectionApi();

        public static JsonObjectAttribute JsonObjectAttribute()
        {
            return Api.ObjectAttributes.New();
        }

        public static JsonObjectAttribute JsonObjectAttribute(MemberSerialization memberSerialization)
        {
            return Api.ObjectAttributes.New(memberSerialization);
        }

        public static JsonObjectAttribute JsonObjectAttribute(string id)
        {
            return Api.ObjectAttributes.New(id);
        }
    }
}
