

using Root.Coding.Code.Models.E01D.Base.Logging;

namespace Root.Coding.Code.Api.E01D.Base.Logging
{
    public interface Logger_I
    {
        //Models.E01D.Base.Logging.LogEntry_I LogCritical(System.Exception exception, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogCritical(Context_I context, System.Exception exception, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogException(System.Exception exception, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogException(Context_I context, System.Exception exception, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogError(string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogError(Context_I context, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogWarning(string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogWarning(Context_I context, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogInfo(string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogInfo(Context_I context, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogTrace(string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogTrace(Context_I context, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogDebug(string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogDebug(Context_I context, string message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogDebug(object message, string memberName, string filePath, int lineNumber);

        //Models.E01D.Base.Logging.LogEntry_I LogDebug(Context_I context, object message, string memberName, string filePath, int lineNumber);

        LogEntry_I Log<TMessageType>(LogSignal_I signal);
    }
    
}
