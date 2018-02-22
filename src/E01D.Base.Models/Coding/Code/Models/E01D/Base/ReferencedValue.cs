namespace Root.Coding.Code.Models.E01D.Base
{
    public class ReferencedValue<T>
        where T:class
    {
        public T Value { get; set; }

        public object SyncRoot = new object();
    }
}
