namespace Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl
{
    public class AvlStackNode<TNode>
    {
        public AvlStackNode<TNode> Previous { get; set; }

        public TNode Node { get; set; }

        public int ImmediateChangeInBalanceFactor { get; set; }
    }
}
