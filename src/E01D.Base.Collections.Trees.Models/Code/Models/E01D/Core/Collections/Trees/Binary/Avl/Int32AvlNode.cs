namespace Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl
{
    public class Int32AvlNode : AvlNode_I<Int32AvlNode, int>
    {
        public Int32AvlNode Left { get; set; }

        public Int32AvlNode Right { get; set; }

        public int BalanceFactor { get; set; }

        public int Key { get; set; }

        public override string ToString()
        {
            return $"K: {Key}, {Left?.Key.ToString() ?? "?"} | {Right?.Key.ToString() ?? "?"}, BF: {BalanceFactor}";
        }
    }
}
