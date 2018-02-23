using E01D.Base.Debugging.Enums.Coding.Code.Enums.E01D.Base.Debugging;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface DebugApi_I
    {
        bool Assert(bool condition);

        bool Assert(bool condition, string message);

        bool Assert(bool condition, AssertionHandlingMethod method, string message);

        void WriteLine(string line);
    }
}
