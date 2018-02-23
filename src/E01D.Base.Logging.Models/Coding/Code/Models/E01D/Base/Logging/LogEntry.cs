using System;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public class LogEntry:LogEntry_I
    {
        public string CallerMemberName { get; set; }

        public string CallerFilePath { get; set; }

        public int CallerLineNumber { get; set; }

        public DateTime CreatedUtc { get; set; }

        public long Id { get; set; }

        public int IntLogLevel { get; set; }

        public LogMessage_I Message { get; set; }

        

        public long UserId { get; set; }

        public string Username { get; set; }

        public string StackTrace { get; set; }

        public string Data { get; set; }
    }
}
