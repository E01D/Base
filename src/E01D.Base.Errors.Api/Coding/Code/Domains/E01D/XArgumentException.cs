

using Root.Coding.Code.Models.E01D.Base.Exceptions;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XArgumentException
    {
        public static ArgumentNullException IsNull(string argumentName)
        {
            return XExceptions.Argument.IsNull(argumentName);
        }
    }
}
