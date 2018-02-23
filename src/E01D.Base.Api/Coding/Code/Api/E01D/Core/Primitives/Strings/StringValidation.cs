namespace Root.Coding.Code.Api.E01D.Core.Primitives.Strings
{
    public class StringValidation
    {
        /// <summary>
        /// Throws if a string length is invalid.
        /// </summary>
        /// <param name="value">The string to be checked.</param>
        /// <param name="maxSize">The maximum allowed size of the string.</param>
        public void IsValidLength(string value, int maxSize)
        {
            if (value == null || value.Length < maxSize) return;

            //throw Core.Exceptions.Primitives.Strings.Validation.StringIsNotAValidLength(value, maxSize);
            throw new System.Exception("Value is less than max size.");
        }
    }
}
