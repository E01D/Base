using System.Collections.Generic;
using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonArray : JsonNode
    {
        public bool Inline { get; set; } = false;

        public List<JsonNode> InnerList = new List<JsonNode>();

        public override bool IsArray => true;

        public override bool IsBoolean => false;

        public override bool IsLazyCreator => false;

        public override bool IsNull => false;

        public override bool IsNumber => false;

        public override bool IsObject => false;

        public override bool IsString => false;

        public override JsonNodeType NodeType => JsonNodeType.Array;
    }
}
