namespace Root.Code.Models.E01D.Core.Collections
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode()
        {
            
        }

        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }

        public DoubleLinkedListNode(DoubleLinkedList<T> list, T value)
        {
            List = list;
            Value = value;
        }

        public DoubleLinkedList<T> List { get; set; }

        public DoubleLinkedListNode<T> Next
        {
            //get { return next == null || next == list.head ? null : next; }
            get; set;
        }

        public DoubleLinkedListNode<T> Previous
        {
            //get { return prev == null || this == list.head ? null : prev; }
            get; set;
        }

        public T Value { get; set; }

       
    }
}
