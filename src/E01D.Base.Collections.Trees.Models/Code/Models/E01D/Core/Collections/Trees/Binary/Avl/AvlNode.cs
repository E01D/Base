
using Root.Coding.Code.Domains.E01D;


namespace Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl
{
    public class AvlNode<TNode, TKey, TValue> : AvlNode_I<TNode, TKey, TValue>
        where TNode: AvlNode_I<TNode, TKey, TValue>
    {
        public TNode Left { get; set; }

        public TNode Right { get; set; }

        public int BalanceFactor { get; set; }

        public TKey Key { get; set; }

        public TValue Value { get; set; }

        public override string ToString()
        {
            return XToString.Api.Convert(this);
            
        }
    }
}
