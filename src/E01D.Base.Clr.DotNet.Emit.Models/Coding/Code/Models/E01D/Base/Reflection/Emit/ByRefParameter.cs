using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Core.Reflection.Emit
{
    public class ByRefParameter
    {
        public Expression Value;
        public ParameterExpression Variable;
        public bool IsOut;
    }
}
