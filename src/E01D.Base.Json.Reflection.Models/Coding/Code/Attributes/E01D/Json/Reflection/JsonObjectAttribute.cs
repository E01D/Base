using System;
using Root.Coding.Code.Enums.E01D.Json.Reflection;

namespace Root.Coding.Code.Attributes.E01D.Json.Reflection
{
    /// <summary>
    /// Instructs the <see cref="JsonSerializer"/> how to serialize the object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
    public class JsonObjectAttribute: JsonContainerAttribute
    {
        public override JsonContainerKind Kind => JsonContainerKind.Object;

        

        public JsonObjectAttributeInternals Internals { get; set; } = new JsonObjectAttributeInternals();


    }
}
