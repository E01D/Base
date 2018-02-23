using System;

namespace Root.Coding.Code.Models.E01D.Base.Signalling.Internal
{
    public interface SignalSubscription_I
    {
         /// <summary>
         /// Gets or sets the context underwhich the signal was captured.
         /// </summary>
        object SignalContext { get; set; }

        Action<object> Action { get; set; }

        bool IsAsync { get; set; }
    }
}
