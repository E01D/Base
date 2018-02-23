using Root.Coding.Code.Attributes.E01D.Json.Bson;
using Root.Coding.Code.Enums.E01D.Json;
using Root.Coding.Code.Models.E01D.Json.Writing;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonWriter:JsonWriter
    {
        public BsonBinaryWriter Writer { get; set; }

        public BsonToken Root { get; set; }
        public BsonToken Parent { get; set; }
        public string PropertyName { get; set; }

        public BsonWriterInternal Internals { get; set; } = new BsonWriterInternal();
        public override JsonWriterKind Kind => JsonWriterKind.Bson;
    }
}
