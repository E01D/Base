

using System.Runtime.CompilerServices;
using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Enums.E01D.Base.Logging;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base.Logging;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Domains.E01D
{
    public class XLogBase
    {
        public static LogBaseApi Api { get; set; } = new LogBaseApi();

        public static LogEntry_I LogCritical(string message = null, [CallerMemberName] string callerMemberName = null, 
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
        {
            
            // ReSharper disable ExplicitCallerInfoArgument
            return LogCritical<System.Exception>(null, null, message, callerMemberName, callerFilePath, callerLineNumber);
            // ReSharper restore ExplicitCallerInfoArgument
        }

        public static LogEntry_I LogCritical<TException>(object globalContext, TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
             [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException : System.Exception
        {
            return Api?.Log<TException>(new LogSignal()
            {
                GlobalContext = globalContext,
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

        public static LogEntry_I LogException<TException>(object globalContext, TException exception, string message = null, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TException:System.Exception
        {
            return Api?.Log<TException>(new LogSignal()
            {
                GlobalContext = globalContext,
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

        public static LogEntry_I LogError<TMessage>(object globalContext, TMessage message, [CallerMemberName] string callerMemberName = null,
           [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage: LogMessage_I
        {
            var result = Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = globalContext,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Error

            });

            

            return result;
        }

        

        public static LogEntry_I LogWarning<TMessage>(object globalContext, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = globalContext,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Warning

            });
        }

        public static LogEntry_I LogInfo<TMessage>(object globalContext, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = globalContext,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Info

            });
        }

        public static LogEntry_I LogTrace<TMessage>(object globalContext, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = globalContext,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Trace

            });
        }

        public static LogEntry_I LogDebug<TMessage>(object globalContext, TMessage message, [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = 0)
            where TMessage : LogMessage_I
        {
            return Api?.Log<TMessage>(new LogSignal()
            {
                GlobalContext = globalContext,
                Message = message,
                CallerMemberName = callerMemberName,
                CallerFilePath = callerFilePath,
                CallerLineNumber = callerLineNumber,
                LogLevel = LogLevels.Debug

            });
        }
    }
}
