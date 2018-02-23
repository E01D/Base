using Root.Coding.Code.Api.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Logging;


namespace Root.Coding.Code.Api.E01D.Base
{
    public class LogBaseApi: Logger_I
    {
        public Logger_I DefaultLogger { get; set; } = new DefaultConsoleLogger();

        public LogEntry_I Log<TMessageType>(LogSignal_I logSignal)
        {
            if (logSignal?.Message != null && logSignal.Message.MessageType == null)
            {
                // if the message type is lready set, then save time and no need to do this step.
                logSignal.Message.MessageType = typeof(TMessageType);
            }

            return DefaultLogger?.Log<TMessageType>(logSignal);
        }
    }
}
