using System;
using System.IO;
using System.Text;

namespace Root.Coding.Code.Attributes.E01D.Json.Bson
{
    public class BsonBinaryWriter
    {
        public readonly Encoding Encoding = new UTF8Encoding(false);

        public BinaryWriter Writer { get; set; }

        public byte[] LargeByteBuffer { get; set; }

        public DateTimeKind DateTimeKindHandling { get; set; }

        
    }
}
