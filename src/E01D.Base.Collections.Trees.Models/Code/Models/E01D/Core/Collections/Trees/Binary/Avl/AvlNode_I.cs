namespace Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl
{
    public interface AvlNode_I<TNode, TKey>
        where TNode:AvlNode_I<TNode, TKey>
    {
        TNode Left { get; set; }

        TNode Right { get; set; }

        int BalanceFactor { get; set; }

        TKey Key { get; set; }
    }

    public interface AvlNode_I<TNode, TKey, TValue>: AvlNode_I<TNode, TKey>
        where TNode : AvlNode_I<TNode, TKey, TValue>
    {
        

        TValue Value { get; set; }
    }
}
