using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class ArrayApi
    {
        public ArgumentException InsufficientSpaceToCopy()
        {
            return new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
        }
    }
}
