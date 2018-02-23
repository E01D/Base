using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XProcesses
    {
        public static ProcessesApi Api { get; set; } = new ProcessesApi();

        

        public static void KillIfStarted(AbsoluteFilePath executable)
        {
            Api.KillIfStarted(executable);
        }
    }
}
