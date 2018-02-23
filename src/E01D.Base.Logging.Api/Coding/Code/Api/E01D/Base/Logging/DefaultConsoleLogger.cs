using System;
using Root.Coding.Code.Models.E01D.Base.Logging;

namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public class DefaultConsoleLogger: LoggerApiBaseRoot
    {
        
        public override LogEntry_I OnLog(LogSignal_I info, LogEntry_I entry)
        {
            if (info == null) return null;

            Console.WriteLine(info.Exception?.Message);

            if (info.Message?.Message?.Value != null) Console.WriteLine(info.Message.Message.Value);

            return null;
        }
    }
}
