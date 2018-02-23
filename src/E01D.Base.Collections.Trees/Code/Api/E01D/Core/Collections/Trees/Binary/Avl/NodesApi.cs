using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl
{
    public class NodesApi
    {
        public string ToString<TNode, TKey, TValue>(AvlNode<TNode, TKey, TValue> @this) where TNode : AvlNode_I<TNode, TKey, TValue>
        {
            return $"K: {@this.Key}, {@this.Left?.Key.ToString() ?? "?"} | {@this.Right?.Key.ToString() ?? "?"}, BF: {@this.BalanceFactor}";
        }
    }
}
