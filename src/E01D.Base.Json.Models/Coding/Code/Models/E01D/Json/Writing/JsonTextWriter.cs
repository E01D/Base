using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Writing
{
    public class JsonTextWriter:JsonWriter
    {
        public JsonTextWriterInternal Internals { get; set; } = new JsonTextWriterInternal();
        public override JsonWriterKind Kind => JsonWriterKind.Text;
    }
}
