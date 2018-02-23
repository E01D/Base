using System;

namespace Root.Code.Api.E01D.Core.Collections.Exceptions
{
    public class InvalidOperationApi
    {
        public InvalidOperationException EnumFailedVersion()
        {
            throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
        }

        public InvalidOperationException EnumOperationCantHappen()
        {
            throw new InvalidOperationException("Enumeration has either not started or has already finished.");
        }
    }
}
