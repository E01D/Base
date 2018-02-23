namespace Root.Coding.Code.Models.E01D.Base.Contextual
{
    /// <summary>
    /// Represents a context that can be passed around from one method call to the next in a layered solution.
    /// </summary>
    /// <remarks>There is a lot of debate about whether to use context objects or singletons.  It really comes down to two things: speed and how many packages you are linking.  </remarks>
    public class ContextBase:ContextBase_I
    {
        

        public object SyncRoot { get; set; } = new object();
        //public bool IsGlobal { get; set; }
        //public SecurityContext_I Security { get; set; } = new SecurityContext();
        
        //public TransactionContext_I Transaction { get; set; }
    }
}
