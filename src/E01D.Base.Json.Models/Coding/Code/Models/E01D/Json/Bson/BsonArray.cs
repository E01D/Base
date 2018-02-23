using System.Collections;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Bson;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonArray:BsonToken, IEnumerable<BsonToken>
    {
        public List<BsonToken> Children { get; set; } = new List<BsonToken>();

        public override BsonType Type
        {
            get { return BsonType.Array; }
            set { throw XExceptions.NotSupported.PropertyIsReadOnly(); }
        }

        public IEnumerator<BsonToken> GetEnumerator()
        {
            return Children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
