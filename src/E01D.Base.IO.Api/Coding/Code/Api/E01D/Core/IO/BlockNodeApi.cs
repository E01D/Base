using Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class BlockNodeApi  : AvlIterativeApi<BlockNode, long>
    {
       

        public override long CompareKeys(long x, long y)
        {
            //return 10 - 5 = 5;
            // Rule: If existing is greater than newNode, return greater than 0.  RULE PASSES
            return x - y;
        }

        public override void SetValue(BlockNode existing, BlockNode newNode)
        {
            newNode.Value = existing.Value;
        }
    }
}
