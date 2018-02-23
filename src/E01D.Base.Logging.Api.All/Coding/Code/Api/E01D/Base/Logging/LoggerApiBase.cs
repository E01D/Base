using System.Runtime.CompilerServices;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Base.Logging;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public abstract class LoggerApiBase: LoggerApiBaseRoot, Logger_I
    {

        public bool CanLogCritical()
        {
            return CanLog(LogLevels.Crtical);
        }

        public bool CanLogError()
        {
            return CanLog(LogLevels.Error);
        }

        public bool CanLogWarning()
        {
            return CanLog(LogLevels.Warning);
        }

        public bool CanLogDebug()
        {
            return CanLog(LogLevels.Debug);
        }

        public bool CanLogInfo()
        {
            return CanLog(LogLevels.Info);
        }

        public bool CanLogTrace()
        {
            return CanLog(LogLevels.Trace);
        }

        public bool CanLog(LogLevels logLevel)
        {
            return CanLog(XContextualBase.GetGlobal(), logLevel);
        }


        public LogEntry_I LogCritical<TException>(TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException:System.Exception
        {
            return Log<TException>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Exception = exception,
                Message = new ExceptionMessage<TException>()
                {
                    Message = new Message()
                    {
                        Value = message ?? exception?.Message
                    }
                },
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Crtical

            });

        }

       

        public LogEntry_I LogException<TException>(TException exception, string message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return Log<TException>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Exception = exception,
                Message = new ExceptionMessage<TException>()
                {
                    Message = new Message()
                    {
                        Value = message ?? exception?.Message
                    }
                },
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Error

            });
        }

      

        public LogEntry_I LogError<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
           [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Error

            });
        }

        public LogEntry_I LogWarning<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Warning

            });
        }

  

        public LogEntry_I LogInfo<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Info

            });
        }

        

        public LogEntry_I LogTrace<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Trace

            });
        }

        public LogEntry_I LogDebug<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Debug

            });
        }

        

        



       
    }
}
