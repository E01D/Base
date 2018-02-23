using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public interface LogMessage_I
    {
        Message_I Message { get; }

        System.Type MessageType { get; set; }
    }
}
