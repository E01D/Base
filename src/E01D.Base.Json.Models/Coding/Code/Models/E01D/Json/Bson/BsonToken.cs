using Root.Coding.Code.Enums.E01D.Json.Bson;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public abstract class BsonToken
    {
        public abstract BsonType Type { get; set; }
        public BsonToken Parent { get; set; }
        public int CalculatedSize { get; set; }
    }
}
