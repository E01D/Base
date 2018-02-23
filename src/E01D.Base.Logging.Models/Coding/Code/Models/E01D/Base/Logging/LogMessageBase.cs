using System;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public abstract class LogMessageBase:LogMessage_I
    {
        public Message_I Message {get; set; } 
        public abstract Type MessageType { get; set; }
    }
}
