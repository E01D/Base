namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public class Signal<TSignalContent>:TypeReferencedSignalBase, StandardSignal_I
    {
        /// <summary>
        /// Get or sets the action to be performed on the content of the signal
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the content of the signal
        /// </summary>
        public TSignalContent Content { get; set; }

        /// <summary>
        /// Gets the content of the signal
        /// </summary>
        object StandardSignal_I.Content => Content;

        /// <summary>
        /// Gets or sets the id of the signal relative to the sender.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the messages associated with the signal
        /// </summary>
        public SignalMessage_I[] Messages { get; set; }
    }

    public class StandardSignal:TypeReferencedSignalBase, StandardSignal_I
    {
        /// <summary>
        /// Get or sets the action to be performed on the content of the signal
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the content of the signal
        /// </summary>
        public object Content { get; set; }

        /// <summary>
        /// Gets or sets the id of the signal relative to the sender.
        /// </summary>
        public long Id { get; set; }

        public SignalMessage_I[] Messages { get; set; }
    }
}
