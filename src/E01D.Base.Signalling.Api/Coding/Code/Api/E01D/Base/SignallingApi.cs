using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Signalling.Internal;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class SignallingApi: SignallingApi_I
    {
        public SignalSubscription_I Subscribe<T>(Action<T> action, bool isAsync)
            where T : class
        {
            throw XExceptions.NotImplemented.CommentedOutTemporarily();
            //var siganlContextHost = _.ContextAs<SignalingContextHost_I>();

            //lock (siganlContextHost.Signaling.SyncRoot)
            //{
            //    Action<Context_I, object> toExecute;

            //    if (isAsync)
            //    {
            //        toExecute = (signalContext, objectToExecute) => Task.Factory.StartNew(() =>
            //        {
            //            action(signalContext as TContext, objectToExecute as T);
            //        });
            //    }
            //    else
            //    {
            //        toExecute = (signalContext, objectToExecute) => action(signalContext as TContext, objectToExecute as T);
            //    }

            //    var subscription = new SignalSubscription()
            //    {
            //        SignalContext = context,
            //        Action = toExecute,

            //    };

            //    var typeHandle = typeof(T).TypeHandle;

            //    List<SignalSubscription_I> signals;

            //    if (!siganlContextHost.Signaling.Subscriptions.TryGetValue(typeHandle, out signals))
            //    {
            //        signals = new List<SignalSubscription_I>();

            //        siganlContextHost.Signaling.Subscriptions.Add(typeHandle, signals);
            //    }

            //    signals.Add(subscription);

            //    return subscription;
            //}
        }

        

        public void Signal<T>(T signal)
        {
            throw XExceptions.NotImplemented.CommentedOutTemporarily();
            //var siganlContextHost = _.ContextAs<SignalingContextHost_I>();

            //lock (siganlContextHost.Signaling.SyncRoot)
            //{
            //    var typeHandle = typeof(T).TypeHandle;

            //    List<SignalSubscription_I> signals;

            //    if (!siganlContextHost.Signaling.Subscriptions.TryGetValue(typeHandle, out signals)) return;

            //    // ReSharper disable once ForCanBeConvertedToForeach
            //    for (var i = 0; i < signals.Count; i++)
            //    {
            //        signals[i].Action(signals[i].SignalContext, signal);   
            //    }
            //}
        }
    }
}
