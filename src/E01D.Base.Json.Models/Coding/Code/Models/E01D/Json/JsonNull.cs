using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonNull : JsonNode
    {
        public override bool IsArray => false;

        public override bool IsBoolean => false;

        public override bool IsLazyCreator => false;

        public override bool IsNull => true;

        public override bool IsNumber => false;

        public override bool IsObject => false;

        public override bool IsString => false;

        public override JsonNodeType NodeType => JsonNodeType.Null;
    }
}
