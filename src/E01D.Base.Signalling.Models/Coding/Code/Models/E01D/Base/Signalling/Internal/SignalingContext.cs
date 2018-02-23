using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Signalling.Internal
{
    public class SignalingContext
    {
        public Dictionary<RuntimeTypeHandle, List<SignalSubscription_I>> Subscriptions { get; set; } = new Dictionary<RuntimeTypeHandle, List<SignalSubscription_I>>();
        public object SyncRoot { get; set; } = new object();

        //public Dictionary<string, SignalAcquisitionMethod> SignalAcquisitionMethods { get; set; } = new Dictionary<string, SignalAcquisitionMethod>();

        //public Dictionary<string, SignalProcessor> SignalProcessors { get; set; } = new Dictionary<string, SignalProcessor>();
    }
}
