using System;
using Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Arguments;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions
{
    public class ArgumentApi
    {
        public OutOfRangeApi OutOfRange { get; set; } = new OutOfRangeApi();

        public ArgumentException ArrayPlusOffTooSmall()
        {
            return new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
        }

        public ArgumentException AddingDuplicateWithKey(object key)
        {
            var xValue = key ?? "(null)";

            return new ArgumentException($"An item with the same key has already been added. Key: {xValue}");
        }

        public ArgumentException NonNegativeNumberRequired()
        {
            return new ArgumentException("Non-negative number required");
        }

        public ArgumentException NonNegativeNumberRequired(string argumentName)
        {
            return new ArgumentException($"Non-negative number required for argument {argumentName}");
        }

        public Root.Coding.Code.Models.E01D.Base.Exceptions.ArgumentNullException IsNull(string argumentName)
        {
            return new Root.Coding.Code.Models.E01D.Base.Exceptions.ArgumentNullException(argumentName);
        }


        public ArgumentException InvalidOffsetLength(string argumentName)
        {
            return new ArgumentException(argumentName, "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
        }

        public Root.Coding.Code.Models.E01D.Base.Exceptions.ArgumentNullException Null(string argumentName)
        {
            return IsNull(argumentName);
        }

        public ArgumentException InsufficientSpace()
        {
            return new ArgumentException("Insufficient space in the target location to copy the information.");
        }

        public ArgumentException RankMultiDimNotSupported(string arrayName)
        {
            return new ArgumentException("Only single dimensional arrays are supported for the requested action.");
        }

        public ArgumentException NonZeroLowerBound(string arrayName)
        {
            return new ArgumentException("The lower bound of target array must be zero.");
        }

        public ArgumentException InvalidArrayType(string arrayName)
        {
            return new ArgumentException("Target array type is not compatible with the type of items in the collection.");
        }
    }
}
