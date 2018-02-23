using Root.Coding.Code.Attributes.E01D.Json.Reflection;

namespace Root.Coding.Code.Api.E01D.Json.Reflection
{
    public class JsonArrayAttributeApi
    {
        

        public JsonArrayAttributeInternals Internal(JsonArrayAttribute attribute)
        {
            return attribute.Internals;
        }
    }
}
