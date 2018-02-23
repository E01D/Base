using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Async
{
    public static class CancellationTokenExts
    {
        public static Task CancelIfRequestedAsync(this CancellationToken cancellationToken)
        {
            return XAsync.Api.CancellationTokens.CancelIfRequestedAsync(cancellationToken);
        }

        public static Task<T> CancelIfRequestedAsync<T>(this CancellationToken cancellationToken)
        {
            return XAsync.Api.CancellationTokens.CancelIfRequestedAsync<T>(cancellationToken);
        }

        // From 4.6 on we could use Task.FromCanceled(), but we need an equivalent for
        // previous frameworks.
        public static Task FromCanceled(this CancellationToken cancellationToken)
        {
            return XAsync.Api.CancellationTokens.FromCanceled(cancellationToken);
        }

        public static Task<T> FromCanceled<T>(this CancellationToken cancellationToken)
        {
            return XAsync.Api.CancellationTokens.FromCanceled<T>(cancellationToken);
        }
    }
}
