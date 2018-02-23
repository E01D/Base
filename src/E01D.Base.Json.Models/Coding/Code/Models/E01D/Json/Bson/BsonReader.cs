using System;
using System.Collections.Generic;
using System.IO;
using Root.Coding.Code.Api.E01D.Json.Bson;
using Root.Coding.Code.Enums.E01D.Json.Bson;
using Root.Coding.Code.Models.E01D.Json.Codecs;

namespace Root.Coding.Code.Models.E01D.Json.Bson
{
    public class BsonReader: JsonReadContext
    {
        public BinaryReader Reader { get; set; } 
        public List<BsonContainerContext> Stack { get; set; }

        public byte[] ByteBuffer { get; set; }
        public char[] CharBuffer { get; set; }

        public BsonType CurrentElementType { get; set; }
        public BsonReaderState BsonReaderState { get; set; }
        public BsonContainerContext CurrentContext { get; set; }

        public bool ReadRootValueAsArray { get; set; }
        public bool JsonNet35BinaryCompatibility { get; set; }
        public DateTimeKind DateTimeKindHandling { get; set; } 
    }
}
