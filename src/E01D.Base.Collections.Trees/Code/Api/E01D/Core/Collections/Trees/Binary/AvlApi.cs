using System;
using Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl;
using Root.Code.Models.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Api.E01D.Core.Collections.Trees.Binary
{
    public class AvlApi
    {
        public NodesApi Nodes { get; set; } = new NodesApi();

        public TNode Find<TNode>(TNode node, int key)
            where TNode : class, AvlNode_I<TNode, int>
        {
            return Find(node, key, (x, y) => (x - y));
        }

        public TNode Find<TNode>(TNode node, long key)
            where TNode : class, AvlNode_I<TNode, long>
        {
            return Find(node, key, (x, y) => (x - y));
        }

        public TNode Find<TNode>(TNode node, string key)
           where TNode : class, AvlNode_I<TNode, string>
        {
            return Find(node, key, (x, y) => String.CompareOrdinal(x, y));
        }

        public TNode Find<TNode, TKey>(TNode node, TKey key, Func<TKey, TKey, long> comparer)
            where TNode : class, AvlNode_I<TNode, TKey>
        {
            if (node == null) return null;

            var currentNode = node;

            while (currentNode != null)
            {
                var compareValue = comparer(currentNode.Key, key);

                if (compareValue == 0) return currentNode;

                currentNode = compareValue > 0 ? currentNode.Right : currentNode.Left;
            }

            return null;
        }

        public void Iterate<TNode, TKey>(TNode node, Action<TNode> action)
            where TNode: class, AvlNode_I<TNode, TKey>
        {
            if (node == null) return;

            var stack = new IterateNode<TNode>()
            {
                Node = node,
            };

            while (stack != null)
            {
                TNode left;
                TNode right;

                if (stack.Status < 1 && (left = stack.Node.Left) != null)
                {
                    stack.Status = 1;

                    var newstack = new IterateNode<TNode>()
                    {
                        Node = left,
                        Previous = stack,
                    };

                    stack = newstack;

                    continue;
                }

                if (stack.Status < 2)
                {
                    action(stack.Node);

                    stack.Status = 2;

                    continue;
                }

                if (stack.Status < 3 && (right = stack.Node.Right) != null)
                {
                    stack.Status = 3;

                    var newstack = new IterateNode<TNode>()
                    {
                        Node = right,
                        Previous = stack,
                    };

                    stack = newstack;

                    continue;
                }

                stack = stack.Previous;
            }
        }
    }
}
