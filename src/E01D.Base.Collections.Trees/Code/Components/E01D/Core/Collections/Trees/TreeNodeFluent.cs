using Root.Code.Api.E01D.Core.Collections;

namespace Root.Code.Components.E01D.Core.Collections.Trees
{
    public class TreeNodeFluent<TNode, TKey>
    {
        public TNode Root { get; set; }

        public TreeApi_I<TNode, TKey> Api { get; set; }
    }
}
