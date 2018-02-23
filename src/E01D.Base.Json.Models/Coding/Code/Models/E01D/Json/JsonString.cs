using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonString : JsonNode
    {
        public override bool IsArray => false;

        public override bool IsBoolean => false;

        public override bool IsLazyCreator => false;

        public override bool IsNull => false;

        public override bool IsNumber => false;

        public override bool IsObject => false;

        public override bool IsString => true;

        public override JsonNodeType NodeType => JsonNodeType.String;

        public string Data { get; set; }
    }
}
