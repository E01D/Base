using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Api.E01D.Core
{
    public class NumericApi
    {
        public string EnsureDecimalPlace(double value, string text)
        {
            if (double.IsNaN(value) || double.IsInfinity(value) || text.IndexOf('.') != -1 || text.IndexOf('E') != -1 || text.IndexOf('e') != -1)
            {
                return text;
            }

            return text + ".0";
        }

        public string EnsureDecimalPlace(string text)
        {
            if (text.IndexOf('.') != -1)
            {
                return text;
            }

            return text + ".0";
        }
    }
}
