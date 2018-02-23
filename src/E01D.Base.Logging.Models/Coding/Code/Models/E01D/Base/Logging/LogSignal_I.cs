using Root.Coding.Code.Enums.E01D.Base.Logging;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public interface LogSignal_I:LogEntry_I
    {
        object GlobalContext { get; set; }

        System.Exception Exception { get; set; }

        LogLevels LogLevel { get; set; }
    }
}
