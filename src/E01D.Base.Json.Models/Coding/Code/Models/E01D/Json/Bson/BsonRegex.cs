using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Bson;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonRegex : BsonToken
    {
        public BsonString Pattern { get; set; }
        public BsonString Options { get; set; }

        public override BsonType Type
        {
            get { return BsonType.Regex; }
            set { throw XExceptions.NotSupported.PropertyIsReadOnly(); }
        }
    }
}
