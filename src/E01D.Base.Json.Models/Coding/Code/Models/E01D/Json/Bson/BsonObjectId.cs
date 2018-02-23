using System;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    /// <summary>
    /// Represents a BSON Oid (object id).
    /// </summary>
    [Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
    public class BsonObjectId
    {
        /// <summary>
        /// Gets or sets the value of the Oid.
        /// </summary>
        /// <value>The value of the Oid.</value>
        public byte[] Value { get; set; }
    }
}
