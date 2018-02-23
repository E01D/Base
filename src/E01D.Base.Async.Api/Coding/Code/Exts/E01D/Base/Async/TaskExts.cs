using System.Threading.Tasks;

namespace Root.Coding.Code.Exts.E01D.Base.Async
{
    public static class TaskExts
    {
        public static bool IsCompletedSucessfully(this Task task)
        {
            // IsCompletedSucessfully is the faster method, but only currently exposed on .NET Core 2.0
#if NETCOREAPP2_0
            return task.IsCompletedSucessfully;
#else
            return task.Status == TaskStatus.RanToCompletion;
#endif
        }
    }
}
