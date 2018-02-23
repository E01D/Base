using System;

namespace Root.Coding.Code.Api.E01D.Core.Primitives.Int32s
{
    public class Int32Validation
    {
        public void IsBetweenExclusive(int value, int min, int max)
        {
            if (value > min && value < max) return;

            throw new ArgumentException($"Value '{value}' is not between {min} and {max}, exclusively.");

        }

        public void IsBetweenInclusive(int value, int min, int max)
        {
            if (value >= min && value <= max) return;

            throw new ArgumentException($"Value '{value}' is not between {min} and {max}, inclusively.");

        }
    }
}
