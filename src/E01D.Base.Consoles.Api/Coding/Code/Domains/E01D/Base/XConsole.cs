using System.Threading;
using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D.Base
{
    public static class XConsole
    {
        public static ConsoleApi Api { get; set; } = new ConsoleApi();

        public static void ReadLine(out string input, int timeoutMilliseconds = Timeout.Infinite)
        {
            Api.ReadLine(out input, timeoutMilliseconds);
        }

        public static void WaitForAcknowledgement(int timeoutMilliseconds = Timeout.Infinite)
        {
            Api.WaitForAcknowledgement(timeoutMilliseconds);
        }
    }
}
