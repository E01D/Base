using Root.Coding.Code.Models.E01D.Base.Exceptions;

namespace Root.Code.Api.E01D.Core.Collections.Exceptions
{
    public class KeyAlreadyExistsApi
    {
        public KeyAlreadyExistsException General()
        {
            return new KeyAlreadyExistsException();
        }

        public KeyAlreadyExistsException General_Key(string key)
        {
            var exception = new KeyAlreadyExistsException
            {
                Key = key
            };

            return exception;
        }
    }
}
