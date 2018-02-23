using System.Globalization;

namespace Root.Coding.Code.Api.E01D.Core.Primitives
{
    public class DoubleApi
    {
        /// <summary>
        /// Reads the double value from the string value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public double Read(string stringValue)
        {
            if (stringValue == null) return 0;

            if (double.TryParse(stringValue, out double result)) return result;

            return 0;
        }

        /// <summary>
        /// Writes the double value to the string value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="doubleValue"></param>
        public string Write(double doubleValue)
        {
            return doubleValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}
