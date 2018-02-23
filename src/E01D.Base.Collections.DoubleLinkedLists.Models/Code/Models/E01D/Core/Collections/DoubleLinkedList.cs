namespace Root.Code.Models.E01D.Core.Collections
{
    public class DoubleLinkedList<T>
    {
        public int Count { get; set; }
        public DoubleLinkedListNode<T> Head { get; set; }
        public int Version { get; set; }
    }
}
