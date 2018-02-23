using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class ResourceApi
    {
        public Exception NotFound()
        {
            return new Exception("Resource was not found. Stream is null.");
        }
    }
}
