


using System.Runtime.CompilerServices;
using Root.Coding.Code.Api.E01D.Base.Logging;
using Root.Coding.Code.Enums.E01D.Base.Logging;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XLog
    {
        public static LogApi Api { get; set; } = new LogApi();

        public static LogEntry_I LogCritical<TException>(object context, TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
             [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException:System.Exception
        {
            return XLogBase.Api?.Log<TException>(new LogSignal()
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

        public static LogEntry_I LogCritical<TException>(TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return XLogBase.Api?.Log<TException>(new LogSignal()
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

        public static LogEntry_I LogException<TException>(object context, TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return XLogBase.Api?.Log<TException>(new LogSignal()
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

        public static LogEntry_I LogException<TException>(TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return XLogBase.Api?.Log<TException>(new LogSignal()
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

        public static LogEntry_I LogError<TMessage>(object context, TMessage message, [CallerMemberName] string callerMemberName = null,
           [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Error

            });
        }

        public static LogEntry_I LogError<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
           [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Error

            });
        }

        public static LogEntry_I LogWarning<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Warning

            });
        }

        public static LogEntry_I LogWarning<TMessage>(object context, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Warning

            });
        }

        public static LogEntry_I LogInfo<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Info

            });
        }

        public static LogEntry_I LogInfo<TMessage>(object context, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Info

            });
        }

        public static LogEntry_I LogTrace<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Trace

            });
        }

        public static LogEntry_I LogTrace<TMessage>(object context, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = context,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Trace

            });
        }

        public static LogEntry_I LogDebug<TMessage>(TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Debug

            });
        }

        public static LogEntry_I LogDebug<TMessage>(object context, LogMessage_I message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return XLogBase.Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = XContextualBase.GetGlobal(),
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Debug

            });
        }

        public static void SetLogLevel(LogLevels logLevel)
        {
            Api.SetLogLevel(logLevel);
        }
    }
}
