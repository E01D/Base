using E01D.Base.Debugging.Enums.Coding.Code.Enums.E01D.Base.Debugging;
using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XDebug
    {
        public static DebugApi_I Api { get; set; } = new DebugApi();

        

        static XDebug()
        {
            
        }

        public static bool Assert(bool condition)
        {
            return Api.Assert(condition);
        }

        public static bool Assert(bool condition, string message)
        {
            return Api.Assert(condition, message);
        }

        public static bool Assert(bool condition, AssertionHandlingMethod method, string message)
        {
            return Api.Assert(condition, method, message);
        }

        public static void WriteLine(string line)
        {
            Api.WriteLine(line);
        }
    }
}
