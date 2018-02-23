using System.Globalization;

namespace Root.Coding.Code.Api.E01D.Core.Primitives
{
    public class BoolApi
    {
        /// <summary>
        /// Reads the bool value from the string value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Read(string stringValue)
        {
            if (stringValue == null) return false;

            if (bool.TryParse(stringValue, out bool result)) return result;

            return false;
        }

        /// <summary>
        /// Writes the bool value to the string value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="primitiveValue"></param>
        public string Write(bool primitiveValue)
        {
            return primitiveValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}
