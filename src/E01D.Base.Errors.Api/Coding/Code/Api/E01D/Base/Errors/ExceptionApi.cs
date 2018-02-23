using Root.Coding.Code.Api.E01D.Base.Errors.Exceptions;

namespace Root.Coding.Code.Api.E01D.Base.Errors
{
    public class ExceptionApi
    {
        public ArgumentApi Argument { get; set; } = new ArgumentApi();

        public ArrayApi Arrays { get; set; } = new ArrayApi();

        public GeneralApi General { get; set; } = new GeneralApi();
        public InvalidOperationApi InvalidOperation { get; set; } = new InvalidOperationApi();
        
        
        public NotImplementedApi NotImplemented { get; set; } = new NotImplementedApi();

        public NotSupportedApi NotSupported { get; set; } = new NotSupportedApi();
        public ResourceApi ResourceApi { get; set; } = new ResourceApi();

        public PrimitivesApi Primitives { get; set; } = new PrimitivesApi();
        public PropertiesApi Properites { get; set; } = new PropertiesApi();

        public string GetFullMessage(System.Exception exeption)
        {
            return exeption?.Message;
        }

        public string GetExceptionMessage(System.Exception exception, bool showServerExceptions)
        {
            throw new System.NotImplementedException();
        }
    }
}
