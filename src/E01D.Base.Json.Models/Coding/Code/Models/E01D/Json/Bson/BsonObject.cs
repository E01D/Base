using System.Collections;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Bson;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonObject: BsonToken, IEnumerable<BsonProperty>
    {
        public List<BsonProperty> Children { get; } = new List<BsonProperty>();

        public override BsonType Type
        {
            get { return BsonType.Object; }
            set { throw XExceptions.NotSupported.PropertyIsReadOnly(); }
        }

        public IEnumerator<BsonProperty> GetEnumerator()
        {
            return Children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
