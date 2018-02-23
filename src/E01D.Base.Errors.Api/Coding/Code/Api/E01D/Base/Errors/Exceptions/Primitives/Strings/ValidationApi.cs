

using Root.Coding.Code.Models.E01D.Base.Exceptions;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Primitives.Strings
{
    public class ValidationApi
    {
        public Exception StringIsNotAValidLength(string value, int maxSize)
        {
            return new Exception($"String is longer than the allowed size of {maxSize}.  String is: {value}");
        }
    }
}
