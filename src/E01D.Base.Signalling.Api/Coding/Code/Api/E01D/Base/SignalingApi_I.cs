using System;
using Root.Coding.Code.Models.E01D.Base.Signalling;
using Root.Coding.Code.Models.E01D.Base.Signalling.Internal;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface SignallingApi_I
    {
        SignalSubscription_I Subscribe<T>(Action<T> action, bool isAsync)
            where T : class;

        void Signal<T>(T signal);
    }
}
