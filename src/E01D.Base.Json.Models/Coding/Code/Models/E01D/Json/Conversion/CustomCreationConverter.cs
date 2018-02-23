using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Conversion
{
    public class CustomCreationConverter : JsonConverter
    {
        public override JsonConverterKind Kind => JsonConverterKind.CustomCreation;
    }
}
