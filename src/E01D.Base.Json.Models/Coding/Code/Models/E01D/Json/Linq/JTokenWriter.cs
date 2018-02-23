using Root.Coding.Code.Enums.E01D.Json;
using Root.Coding.Code.Models.E01D.Json.Writing;

namespace Root.Coding.Code.Models.E01D.Json.Linq
{
    public class JTokenWriter:JsonWriter
    {
        public override JsonWriterKind Kind => JsonWriterKind.Token;
    }
}
