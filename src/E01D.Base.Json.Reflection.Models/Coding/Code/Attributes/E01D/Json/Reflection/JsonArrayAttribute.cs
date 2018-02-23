using Root.Coding.Code.Enums.E01D.Json.Reflection;

namespace Root.Coding.Code.Attributes.E01D.Json.Reflection
{
    public class JsonArrayAttribute:JsonContainerAttribute
    {
        public JsonArrayAttributeInternals Internals { get; set; }
        public override JsonContainerKind Kind => JsonContainerKind.Array;
    }
}
