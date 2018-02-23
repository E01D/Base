using System.Globalization;

namespace Root.Coding.Code.Api.E01D.Core.Primitives
{
    public class Int32Api
    {
        public Int32s.Int32Validation Validation { get; set; } = new Int32s.Int32Validation();

        /// <summary>
        /// Reads the int value from the string value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Read(string stringValue)
        {
            if (int.TryParse(stringValue, out int result)) return result;

            return 0;
        }

        /// <summary>
        /// Writes the int value to the string value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="intValue"></param>
        public string Write(int intValue)
        {
            return intValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}
