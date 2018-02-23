using Root.Code.Api.E01D.Core.Collections.Exceptions;

namespace Root.Code.Api.E01D.Core.Collections
{
    public class ExceptionApi
    {
        public ArgumentApi Arguments { get; set; } = new ArgumentApi();

        public KeyAlreadyExistsApi KeyAlreadyExists { get; set; } = new KeyAlreadyExistsApi();

        public InvalidOperationApi InvalidOperation { get; set; } = new InvalidOperationApi();
    }
}
