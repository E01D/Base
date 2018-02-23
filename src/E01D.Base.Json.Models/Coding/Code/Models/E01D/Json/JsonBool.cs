using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonBool : JsonNode
    {
        
        public override bool IsArray => false;

        public override bool IsBoolean => true;

        public override bool IsLazyCreator => false;

        public override bool IsNull => false;

        public override bool IsNumber => false;

        public override bool IsObject => false;

        public override bool IsString => false;

        public override JsonNodeType NodeType => JsonNodeType.Bool;

        public bool Data { get; set; }
    }
}
