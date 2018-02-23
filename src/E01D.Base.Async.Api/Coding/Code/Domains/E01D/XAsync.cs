using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XAsync
    {
        public static AsyncApi Api { get; set; } = new AsyncApi();

        // Task.Delay(0) is optimised as a cached task within the framework, and indeed
        // the same cached task that Task.CompletedTask returns as of 4.6, but we'll add
        // our own cached field for previous frameworks.
        public static Task CompletedTask => Api.CompletedTask;

        public static Task<bool> False = Api.False;
        public static Task<bool> True = Api.True;

        public static Task<bool> ToAsync(bool value) => Api.ToAsync(value);

        // From 4.6 on we could use Task.FromCanceled(), but we need an equivalent for
        // previous frameworks.
        public static Task FromCanceled(CancellationToken cancellationToken)
        {
            return Api.CancellationTokens.FromCanceled(cancellationToken);
        }

        public static Task<T> FromCanceled<T>(CancellationToken cancellationToken)
        {
            return Api.CancellationTokens.FromCanceled<T>(cancellationToken);
        }
    }
}
