using Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Primitives;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class PrimitivesApi
    {
        public StringApi Strings { get; set; } = new StringApi();

        public Int32Api Int32s { get; set; } = new Int32Api();
    }
}
