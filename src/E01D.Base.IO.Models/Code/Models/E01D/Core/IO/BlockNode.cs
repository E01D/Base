using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Models.E01D.Core.IO
{
    public class BlockNode: AvlNode_I<BlockNode, long>
    {
        public BlockNode Left { get; set; }

        public BlockNode Right { get; set; }

        public int BalanceFactor { get; set; }

        public long Key { get; set; }

        public Block Value { get; set; }

        public override string ToString()
        {
            return $"K: {Key}, {Left?.Key.ToString() ?? "?"} | {Right?.Key.ToString() ?? "?"}, BF: {BalanceFactor}";
        }
    }
}
