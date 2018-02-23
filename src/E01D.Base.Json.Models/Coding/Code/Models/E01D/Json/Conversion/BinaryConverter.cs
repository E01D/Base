using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json.Conversion
{
    public class BinaryConverter:JsonConverter
    {
        public override JsonConverterKind Kind => JsonConverterKind.Binary;
    }
}
