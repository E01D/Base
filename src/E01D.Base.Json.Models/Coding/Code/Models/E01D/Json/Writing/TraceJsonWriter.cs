using System.IO;
using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Writing
{
    public class TraceJsonWriter:JsonWriter
    {
        public JsonWriter InnerWriter { get; set; }
        public JsonTextWriter TextWriter { get; set; }
        public StringWriter Sw { get; set; }
        public override JsonWriterKind Kind => JsonWriterKind.Trace;
    }
}
