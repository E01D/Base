using System.Runtime.CompilerServices;
using Root.Coding.Code.Enums.E01D.Base.Logging;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;
using Root.Coding.Code.Models.E01D.Base.Security.Contextual;


namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public abstract class LoggerApiBaseRoot: Logger_I
    {

        
        public bool CanLog(object globalContext, LogLevels logLevel)
        {
            var contextHost = globalContext as LogContextHost_I;

            var context = contextHost?.Logging;

            if (context == null) return true;

            return (int)context.LogLevel >= (int)logLevel;
        }

        public LogEntry_I LogCritical<TException>(object context, TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return Log<TException>(new LogSignal()
            {
                GlobalContext = context,
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

        

        public LogEntry_I LogException<TException>(object context, TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return Log<TException>(new LogSignal()
            {
                GlobalContext = context,
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

       

        public LogEntry_I LogError<TMessage>(object context, LogMessage_I message, [CallerMemberName] string callerMemberName = null,
           [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Error

            });
        }

        

        

        public LogEntry_I LogWarning<TMessage>(object context, LogMessage_I message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Warning

            });
        }

        

        public LogEntry_I LogInfo<TMessage>(object context, LogMessage_I message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Info

            });
        }

        

        public LogEntry_I LogTrace<TMessage>(object context, LogMessage_I message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Trace

            });
        }

        public LogEntry_I LogDebug<TMessage>(object context, LogMessage_I message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Debug

            });
        }

        public LogEntry_I Log<TMessageType>(LogSignal_I logSignal)
        {
            if (logSignal == null) return null;

            if (logSignal?.Message != null && logSignal.Message.MessageType == null)
            {
                // if the message type is lready set, then save time and no need to do this step.
                logSignal.Message.MessageType = typeof(TMessageType);
            }

            if (!CanLog(logSignal.GlobalContext, logSignal.LogLevel)) return null;

            LogEntry_I entry = CreateLogEntry(logSignal);

            return OnLog(logSignal, entry);
        }



        public virtual LogEntry_I CreateLogEntry(LogSignal_I info)
        {
            var securityContextHost = info.GlobalContext as SecurityContextHost_I;

            var securityContext = securityContextHost?.Security;

            

            return new LogEntry()
            {
                CallerFilePath = info.CallerFilePath,
                CallerLineNumber = info.CallerLineNumber,
                CallerMemberName = info.CallerMemberName,
                CreatedUtc = info.CreatedUtc,
                IntLogLevel = (int)info.LogLevel,
                Message = info.Message,
                StackTrace = info.StackTrace,
                UserId = securityContext?.Authentication?.User.UserId ?? 0,
                Username = securityContext?.Authentication?.User.Username
            };
        }

        public abstract LogEntry_I OnLog(LogSignal_I info, LogEntry_I entry);
    }
}
