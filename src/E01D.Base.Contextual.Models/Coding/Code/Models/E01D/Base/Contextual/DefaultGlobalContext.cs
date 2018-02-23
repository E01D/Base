using Root.Coding.Code.Framework.E01D;

namespace Root.Coding.Code.Models.E01D.Base.Contextual
{
    public class DefaultGlobalContext: SyncRooted_I
    {
        public object SyncRoot { get; } = new object();
        
    }
}
