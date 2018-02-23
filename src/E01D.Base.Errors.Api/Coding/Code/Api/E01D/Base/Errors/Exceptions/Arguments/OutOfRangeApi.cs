using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Arguments
{
    public class OutOfRangeApi
    {
        public ArgumentOutOfRangeException Argument(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName);
        }

        public Exception NeedNonNegativeNumber()
        {
            throw new NotImplementedException();
        }

        public ArgumentOutOfRangeException Count(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Count must be positive and count must refer to a location within the string/array/collection.");
        }

        public ArgumentOutOfRangeException Index(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Index was out of range. Must be non-negative and less than the size of the collection.");
        }

        public ArgumentOutOfRangeException NeedNonNegativeNumber(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Non-negative number required.");
        }

        public ArgumentOutOfRangeException SmallCapacity(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Capacity was less than the current size.");
        }

        public ArgumentOutOfRangeException CapacityLessThanZero(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Capacity was less than zero.");
        }

        public ArgumentOutOfRangeException InvalidOffsetLength(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
        }

        public ArgumentOutOfRangeException ListInsert(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Index must be within the bounds of the List.");
        }

        public ArgumentOutOfRangeException BiggerThanCollection(string parameterName)
        {
            return new ArgumentOutOfRangeException(parameterName, "Larger than collection size.");
        }

        public ArgumentOutOfRangeException NeedNonNegNum(string name, int value)
        {
            return new ArgumentOutOfRangeException(name, value, "Non-negative number required.");
        }

        public ArgumentOutOfRangeException BiggerThanCollection(string name, object value)
        {
            return new ArgumentOutOfRangeException(name, value,
                "Must be less than or equal to the size of the collection.");
        }

        public ArgumentOutOfRangeException UnexpectedDateTimeKindValue(string kindName, DateTimeKind kind)
        {
            return new ArgumentOutOfRangeException(kindName, kind, "Unexpected DateTimeKind value.");
        }
    }
}
