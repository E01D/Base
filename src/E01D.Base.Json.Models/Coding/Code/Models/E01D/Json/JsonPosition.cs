using Root.Coding.Code.Enums.E01D.Json.Reflection;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonPosition
    {
        public JsonContainerType Type { get; set; }
        public int Position { get; set; }
        public string PropertyName { get; set; }
        public bool HasIndex { get; set; }
    }
}
