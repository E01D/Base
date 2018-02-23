using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl
{
    public class AvlIterativeInt32Api : AvlIterativeApi<Int32AvlNode, int>
    {
        public AvlIterativeInt32Api()
        {

        }

        public override long CompareKeys(int x, int y)
        {
            //return 10 - 5 = 5;
            // Rule: If existing is greater than newNode, return greater than 0.  RULE PASSES
            return x - y;
        }

        public override void SetValue(Int32AvlNode existing, Int32AvlNode newNode)
        {
            // the value is the key, so it is already set
        }
    }
}
