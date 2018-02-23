using Root.Coding.Code.Enums.E01D.Json.Bson;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonValue:BsonToken
    {
        public object Value
        {
            get; set;
        }

        public override BsonType Type
        {
            get; set;
        }
    }
}
