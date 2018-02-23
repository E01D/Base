using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Signalling.Internal
{
    public interface SignalingContext_I
    {
        Dictionary<RuntimeTypeHandle, List<SignalSubscription_I>> Subscriptions { get; set; }
        object SyncRoot { get; set; } 
    }
}
