using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Primitives
{
    public class PrimitivesApi
    {
        public static BoolApi Bool => XBool.Api;

        public static ConversionApi Conversion => XConvert.Api;

        public static DateTimeApi DateTime => XDateTimes.Api;

        public static EnumApi Enums => XEnums.Api;

        public static GuidApi Guids => XGuids.Api;

        public static StringApi Strings => XStrings.Api;
    }
}
