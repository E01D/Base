using System;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public interface LogEntry_I
    {
        string CallerMemberName { get; set; }

        string CallerFilePath { get; set; }

        int CallerLineNumber { get; set; }

        DateTime CreatedUtc { get; set; }

        long Id { get; set; }

        int IntLogLevel { get; set; }

        LogMessage_I Message { get; set; }



        long UserId { get; set; }

        string Username { get; set; }

        string StackTrace { get; set; }

        string Data { get; set; }
    }
}
