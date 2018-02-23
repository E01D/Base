using Root.Coding.Code.Enums.E01D.Base.Logging;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public class LogContext:LogContext_I
    {
        public LogLevels LogLevel { get; set; } = LogLevels.Debug;
    }
}
