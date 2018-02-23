using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Apis.E01D.Core.Collections
{
    public class DoubleLinkedListNodeApi
    {
        

        public void Invalidate<T>(DoubleLinkedListNode<T> node)
        {
            node.List = null;
            node.Next = null;
            node.Previous = null;
        }
    }
}
