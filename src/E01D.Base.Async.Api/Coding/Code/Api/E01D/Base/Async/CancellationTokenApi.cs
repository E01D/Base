using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Async
{
    public class CancellationTokenApi
    {
        public Task CancelIfRequestedAsync(CancellationToken cancellationToken)
        {
            return cancellationToken.IsCancellationRequested ? FromCanceled(cancellationToken) : null;
        }

        public Task<T> CancelIfRequestedAsync<T>(CancellationToken cancellationToken)
        {
            return cancellationToken.IsCancellationRequested ? FromCanceled<T>(cancellationToken) : null;
        }

        // From 4.6 on we could use Task.FromCanceled(), but we need an equivalent for
        // previous frameworks.
        public Task FromCanceled(CancellationToken cancellationToken)
        {
            XDebug.Assert(cancellationToken.IsCancellationRequested);
            return new Task(() => { }, cancellationToken);
        }

        public Task<T> FromCanceled<T>(CancellationToken cancellationToken)
        {
            XDebug.Assert(cancellationToken.IsCancellationRequested);
            return new Task<T>(() => default(T), cancellationToken);
        }
    }
}
