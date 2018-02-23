using System;

namespace Root.Coding.Code.Models.E01D.Base.Signalling.Internal
{
    public class SignalSubscription:SignalSubscription_I
    {
        public object SignalContext { get; set; }
        public Action<object>  Action { get; set; }

        public bool IsAsync { get; set; }
    }
}
 