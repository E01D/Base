namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonString:BsonValue
    {
        public BsonString()
        {
            Type = Enums.E01D.Json.Bson.BsonType.String;
        }

        public int ByteCount { get; set; }
        public bool IncludeLength { get; set; }
    }
}
