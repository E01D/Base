using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Conversion
{
    class RegexConverter : JsonConverter
    {
        public override JsonConverterKind Kind => JsonConverterKind.Regex;
    }
}
