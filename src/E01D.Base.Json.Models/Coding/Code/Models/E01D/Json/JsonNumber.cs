using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonNumber : JsonNode
    {
        public override bool IsArray => false;

        public override bool IsBoolean => false;

        public override bool IsLazyCreator => false;

        public override bool IsNull => false;

        public override bool IsNumber => true;

        public override bool IsObject => false;

        public override bool IsString => false;

        public override JsonNodeType NodeType => JsonNodeType.Number;
        public double Data { get; set; }
    }
}
