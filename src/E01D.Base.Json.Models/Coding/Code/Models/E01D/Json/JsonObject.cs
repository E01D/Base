using System.Collections.Generic;
using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonObject:JsonNode
    {
        public Dictionary<string, JsonNode> ChildNodes { get; set; } = new Dictionary<string, JsonNode>();

        public bool Inline { get; set; }

        public override bool IsArray => false;

        public override bool IsBoolean => false;

        public override bool IsLazyCreator => false;

        public override bool IsNull => false;

        public override bool IsNumber => false;

        public override bool IsObject => true;

        public override bool IsString => false;

        public override JsonNodeType NodeType => JsonNodeType.Object;

        
    }
}
