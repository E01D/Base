using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Base.Async;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class AsyncApi
    {
        public CancellationTokenApi CancellationTokens { get; set; } = new CancellationTokenApi();

        // Task.Delay(0) is optimised as a cached task within the framework, and indeed
        // the same cached task that Task.CompletedTask returns as of 4.6, but we'll add
        // our own cached field for previous frameworks.
        public readonly Task CompletedTask = Task.Delay(0);

        public readonly Task<bool> False = Task.FromResult(false);
        public readonly Task<bool> True = Task.FromResult(true);

        public Task<bool> ToAsync(bool value) => value ? True : False;

        
    }
}
