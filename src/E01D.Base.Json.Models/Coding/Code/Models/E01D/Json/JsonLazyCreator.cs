using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonLazyCreator: JsonNode
    {
        public override bool IsArray => false;

        public override bool IsBoolean => false;

        public override bool IsNull => false;

        public override bool IsNumber => false;

        public override bool IsObject => false;

        public override bool IsString => false;

        public override bool IsLazyCreator => true;

        public override JsonNodeType NodeType => JsonNodeType.LazyCreator;

        public JsonNode Node { get; set; }
        public string Key { get; set; }
    }
}
