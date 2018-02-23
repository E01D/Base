namespace Root.Code.Models.E01D.Core.Collections
{
    public class IterateNode<TNode>
    {
        public TNode Node { get; set; }

        public IterateNode<TNode> Previous { get; set; }

        public int Status { get; set; }
    }
}
