using Root.Coding.Code.Attributes.E01D.Json.Reflection;

namespace Root.Coding.Code.Api.E01D.Json.Reflection
{
    public class JsonDictionaryAttributeApi
    {
        public JsonDictionaryAttributeInternals Internal(JsonDictionaryAttribute attribute)
        {
            return attribute.Internals;
        }
    }
}
