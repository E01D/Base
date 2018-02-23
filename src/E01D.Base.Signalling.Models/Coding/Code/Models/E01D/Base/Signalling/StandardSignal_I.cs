namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public interface StandardSignal_I
    {
        /// <summary>
        /// Get or sets the action to be performed on the content of the signal
        /// </summary>
        string Action { get;  }

        object Content { get; }

        /// <summary>
        /// Gets or sets the id of the signal relative to the sender.
        /// </summary>
        long Id { get;  }

        SignalMessage_I[] Messages { get;  }
    }
}
