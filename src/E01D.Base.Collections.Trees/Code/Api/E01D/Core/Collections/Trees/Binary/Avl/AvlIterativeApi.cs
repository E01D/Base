using System;
using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl
{
    public abstract class AvlIterativeApi<TNode, TKey, TValue> : AvlIterativeApi<TNode, TKey>
        where TNode : class, AvlNode_I<TNode, TKey, TValue>, new()

    {
        public override void SetValue(TNode existing, TNode newNode)
        {
            newNode.Value = existing.Value;
        }
    }

    public abstract class AvlIterativeApi<TNode, TKey>: AvlIterativeBaseApi<TNode, TKey>
        where TNode: class, AvlNode_I<TNode, TKey>, new()
        
    {
        public override TKey GetKey(TNode node)
        {
            return node.Key;
        }

        public override bool SupportsDuplicateKeys()
        {
            return false;
        }

        public override TNode HandleDuplicateException(TNode existingRoot, TNode currentRoot, TNode newNode)
        {
            throw new Exception("Duplicate key");
        }

        public override TNode CreateNodeInternal(TNode newNode, int balanceFactor)
        {
            return new TNode()
            {
                BalanceFactor = balanceFactor,
                Key = newNode.Key,
                Left = newNode.Left,
                Right = newNode.Right
            };
        }


        public override bool AreSame(TNode nodeA, TNode nodeB)
        {
            return ReferenceEquals(nodeA, nodeB);
        }


        public override TNode GetLeft(TNode existing)
        {
            return existing.Left;
        }


        public override TNode GetRight(TNode existing)
        {
            return existing.Right;
        }


        public override TNode SetLeftInternal(TNode existing, TNode newLeft, int newBalanceFactor)
        {
            return new TNode()
            {
                BalanceFactor = newBalanceFactor,
                Key = existing.Key,
                Left = newLeft,
                Right = existing.Right
            };
        }


        public override TNode SetRightInternal(TNode existing, TNode newRight, int newBalanceFactor)
        {
            return new TNode()
            {
                BalanceFactor = newBalanceFactor,
                Key = existing.Key,
                Left = existing.Left,
                Right = newRight
            };
        }


        public override TNode SetLeftInternal(TNode existing, TNode newLeft)
        {
            return new TNode()
            {
                BalanceFactor = existing.BalanceFactor,
                Key = existing.Key,
                Left = newLeft,
                Right = existing.Right
            };
        }


        public override TNode SetRightInternal(TNode existing, TNode newRight)
        {
            return new TNode()
            {
                BalanceFactor = existing.BalanceFactor,
                Key = existing.Key,
                Left = existing.Left,
                Right = newRight
            };
        }


        public override int GetBalanceFactor(TNode existingRoot)
        {
            return existingRoot.BalanceFactor;
        }

        public override TNode SetBalanceFactorInternal(TNode existing, int newFactor)
        {
            return new TNode()
            {
                BalanceFactor = newFactor,
                Key = existing.Key,
                Left = existing.Left,
                Right = existing.Right
            };
        }


        public override bool IsNull(TNode node)
        {
            return node == null;
        }


        public override TNode NullNode()
        {
            return null;
        }


        public override long Compare(TNode existingRoot, TNode newNode)
        {
            return CompareKeys(existingRoot.Key, newNode.Key);
        }

        

        public override TNode DuplicateNodeInternal(TNode node, TNode left, TNode right)
        {
            var newNode = new TNode()
            {
                BalanceFactor = node.BalanceFactor,
                Key = node.Key,
                Left = left,
                Right = right,
            };

            return newNode;
        }

        public override TNode DuplicateNodeFromNodeInternal(TNode source)
        {
            var newNode = new TNode()
            {
                BalanceFactor = source.BalanceFactor,
                Key = source.Key,
                Left = source.Left,
                Right = source.Right,
            };

            return newNode;
        }


        public override AvlIterativeBaseApi<TNode, TKey> GetApi()
        {
            return this;
        }
    }
}
