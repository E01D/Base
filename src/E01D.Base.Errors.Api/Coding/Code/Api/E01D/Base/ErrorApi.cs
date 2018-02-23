using Root.Coding.Code.Api.E01D.Base.Errors;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ErrorApi
    {
        public ExceptionApi Exceptions { get; set; } = new ExceptionApi();
        public ErrorCollectionApi ErrorCollections { get; set; } = new ErrorCollectionApi();
    }
}
