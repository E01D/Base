using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class DoubleLinkedListNodeExts
    {
        public static void Invalidate<T>(this DoubleLinkedListNode<T> node)
        {
            XDoubleLinkedList.Api.Nodes.Invalidate(node);
        }

        public static void ValidateNewNode<T>(DoubleLinkedListNode<T> node)
        {
            XDoubleLinkedList.Api.Lists.ValidateNewNode<T>(node);
        }
    }
}
