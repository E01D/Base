using Root.Code.Api.E01D.Core.Collections.Exceptions;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Exceptions.E01D
{
    public static class ArgumentApiExt
    {
        public static System.ArgumentException ArrayPlusOffTooSmall(this ArgumentApi arumentApi)
        {
            return XExceptions.Argument.ArrayPlusOffTooSmall();
        }
    }
}
