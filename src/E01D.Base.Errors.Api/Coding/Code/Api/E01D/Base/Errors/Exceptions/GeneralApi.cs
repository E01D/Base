using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class GeneralApi
    {
        public Root.Coding.Code.Models.E01D.Base.Exceptions.Exception Exception(string message)
        {
            return new Root.Coding.Code.Models.E01D.Base.Exceptions.Exception(message);
        }

        public Root.Coding.Code.Models.E01D.Base.Exceptions.Exception Exception(string message, Exception innerException)
        {
            return new Root.Coding.Code.Models.E01D.Base.Exceptions.Exception(message, innerException);
        }
    }
}
