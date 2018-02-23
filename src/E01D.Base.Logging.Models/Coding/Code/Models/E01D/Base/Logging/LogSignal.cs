using System;
using Root.Coding.Code.Enums.E01D.Base.Logging;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public class LogSignal:LogEntry, LogSignal_I
    {
        public LogSignal()
        {
            CreatedUtc = DateTime.UtcNow;
        }

        public object GlobalContext { get; set; }

        public System.Exception Exception { get; set; }

        public LogLevels LogLevel { get; set; }
    }
}
