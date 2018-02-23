using System;

namespace Root.Coding.Code.Attributes.E01D.Json
{
    /// <summary>
    /// Instructs the <see cref="JsonSerializer"/> not to serialize the public field or public read/write property value.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class JsonIgnoreAttribute:System.Attribute
    {

    }
}
