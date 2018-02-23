using System.Diagnostics;

namespace Root.Coding.Code.Models.E01D.Base
{
    public class DebugContext: DebugContext_I
    {
        public DebugContext()
        {
            IsAttached = Debugger.IsAttached;

            IsEnabled = IsAttached;
        }

        public bool IsAttached { get; }

        public bool IsConsoleEnabled { get; set; }

        public bool IsEnabled { get; set; }
    }
}
