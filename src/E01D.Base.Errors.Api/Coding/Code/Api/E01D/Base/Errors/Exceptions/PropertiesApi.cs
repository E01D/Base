using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class PropertiesApi
    {
        public Exception DoesNotSupportValueSetting(Func<string> func)
        {
            return new Root.Coding.Code.Models.E01D.Base.Exceptions.Exception("Property does not support value setting.");
        }
    }
}
