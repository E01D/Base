

using Root.Coding.Code.Enums.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Logging;

namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public class LogApi
    {
        public Logger_I DefaultLogger { get; set; }

        public Logger_I Get<TTargetType>()
        {
            throw new System.NotImplementedException();
        }

        public LogEntry_I Log<TMessage>(LogSignal_I logSignal)
            where TMessage:LogMessage_I
        {
            return DefaultLogger?.Log<TMessage>(logSignal);
        }

        public void SetLogLevel(LogLevels logLevel)
        {
            throw new System.NotImplementedException();
        }
    }
}
