using Root.Code.Api.E01D.Core.Math;

namespace Root.Code.Api.E01D.Core
{
    public class MathApi
    {
        public GeneralApi General { get; set; } = new GeneralApi();

        public decimal RoundDownToNearestDecimal(decimal number, decimal threshold)
        {
            // prevent divide by zero.
            if (threshold == 0)
            {
                return number;
            }

            return System.Math.Floor(number / threshold) * threshold;

        }

        public decimal RoundUpToNearestDecimal(decimal number, decimal threshold)
        {
            // prevent divide by zero.
            if (threshold == 0)
            {
                return number;
            }

            return System.Math.Ceiling(number / threshold) * threshold;

        }
    }
}
