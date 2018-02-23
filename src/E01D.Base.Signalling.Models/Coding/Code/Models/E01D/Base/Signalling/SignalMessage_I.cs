namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public interface SignalMessage_I
    {
        object Content { get; set; }

        string MessageType { get; set; }
    }
}
