using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Enums.E01D.Base.Logging;

namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public class LogContext:LogContext_I
    {
        public LogLevels LogLevel { get; set; }
    }
}
