

using System;

namespace Root.Code.Api.E01D.Core.Collections.Exceptions
{
    public class ArgumentApi
    {
        public ArgumentException ArrayPlusOffTooSmall()
        {
            return new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
        }
    }
}
