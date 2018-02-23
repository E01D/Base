namespace Root.Code.Models.E01D.Core.Collections
{
    public class ArrayList: List_I
    {
        public int Capacity { get; set; }

        public object[] Items { get; set; }

        
        public int Count { get; set; }

        public int Version { get; set; }

        public object SyncRoot { get; } = new object();

        public virtual bool IsFixedSize => false;


        // Is this ArrayList read-only?
        public virtual bool IsReadOnly => false;

        // Is this ArrayList synchronized (thread-safe)?
        public virtual bool IsSynchronized => false;

       
    }
}
