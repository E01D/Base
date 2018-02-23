using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Api.E01D.Base.NetFramework
{
    public class ToStringApi
    {
        /// <summary>
        /// Provides a default ToString implementation for classes that choose to override the default .NET method
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public string ConvertToString(object @this)
        {
            return @this?.GetType().FullName ?? string.Empty;
        }
    }
}
