using System.Globalization;

namespace Root.Coding.Code.Api.E01D.Core.Primitives
{
    public class SingleApi
    {
        /// <summary>
        /// Reads the single value from the json node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public float Read(string stringValue)
        {
            if (float.TryParse(stringValue, out float result)) return result;

            return 0;
        }

        /// <summary>
        /// Writes the single value to the json node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="doubleValue"></param>
        public string Write(float singleValue)
        {
            return singleValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}
