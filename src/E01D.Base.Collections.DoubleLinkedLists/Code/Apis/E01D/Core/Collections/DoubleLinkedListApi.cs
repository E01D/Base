using System;
using System.Collections.Generic;
using System.Diagnostics;
using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Apis.E01D.Core.Collections
{
    public class DoubleLinkedListApi
    {
        public DoubleLinkedListNode<T> AddAfter<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, T value)
        {
            ValidateNode(@this, node);
            DoubleLinkedListNode<T> result = new DoubleLinkedListNode<T>(node.List, value);
            InternalInsertNodeBefore(@this, node.Next, result);
            return result;
        }

        public void AddAfter<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, DoubleLinkedListNode<T> newNode)
        {
            ValidateNode(@this, node);
            ValidateNewNode(newNode);
            InternalInsertNodeBefore(@this, node.Next, newNode);
            newNode.List = @this;
        }

        public DoubleLinkedListNode<T> AddBefore<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, T value)
        {
            ValidateNode(@this, node);
            DoubleLinkedListNode<T> result = new DoubleLinkedListNode<T>(node.List, value);
            InternalInsertNodeBefore(@this, node, result);
            if (node == @this.Head)
            {
                @this.Head = result;
            }
            return result;
        }

        public void AddBefore<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, DoubleLinkedListNode<T> newNode)
        {
            ValidateNode(@this, node);
            ValidateNewNode(newNode);
            InternalInsertNodeBefore(@this, node, newNode);
            newNode.List = @this;
            if (node == @this.Head)
            {
                @this.Head = newNode;
            }
        }

        public DoubleLinkedListNode<T> AddFirst<T>(DoubleLinkedList<T> @this, T value)
        {
            DoubleLinkedListNode<T> result = new DoubleLinkedListNode<T>(@this, value);
            if (@this.Head == null)
            {
                InternalInsertNodeToEmptyList(@this, result);
            }
            else
            {
                InternalInsertNodeBefore(@this, @this.Head, result);
                @this.Head = result;
            }
            return result;
        }

        public void AddFirst<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            ValidateNewNode(node);

            if (@this.Head == null)
            {
                InternalInsertNodeToEmptyList(@this, node);
            }
            else
            {
                InternalInsertNodeBefore(@this, @this.Head, node);
                @this.Head = node;
            }
            node.List = @this;
        }

        public DoubleLinkedListNode<T> AddLast<T>(DoubleLinkedList<T> @this, T value)
        {
            DoubleLinkedListNode<T> result = new DoubleLinkedListNode<T>(@this, value);
            if (@this.Head == null)
            {
                InternalInsertNodeToEmptyList(@this, result);
            }
            else
            {
                InternalInsertNodeBefore(@this, @this.Head, result);
            }
            return result;
        }

        public void AddLast<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            ValidateNewNode(node);

            if (@this.Head == null)
            {
                InternalInsertNodeToEmptyList(@this, node);
            }
            else
            {
                InternalInsertNodeBefore(@this, @this.Head, node);
            }
            node.List = @this;
        }

        public void Clear<T>(DoubleLinkedList<T> @this)
        {
            DoubleLinkedListNode<T> current = @this.Head;
            while (current != null)
            {
                DoubleLinkedListNode<T> temp = current;
                current = current.Next;   // use Next the instead of "next", otherwise it will loop forever
                temp.Invalidate();
            }

            @this.Head = null;
            @this.Count = 0;
            @this.Version++;
        }

        public bool Contains<T>(DoubleLinkedList<T> @this, T value)
        {
            return Find(@this, value) != null;
        }

        public void CopyTo<T>(DoubleLinkedList<T> @this, T[] array, int index)
        {
            if (array == null)
            {
                throw XExceptions.Argument.Null(nameof(array));
            }

            if (index < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegNum(nameof(index), index);
            }

            if (index > array.Length)
            {
                throw XExceptions.Argument.OutOfRange.BiggerThanCollection(nameof(index), index);
                
            }

            if (array.Length - index < @this.Count)
            {
                throw XExceptions.Argument.InsufficientSpace();
            }

            DoubleLinkedListNode<T> node = @this.Head;
            if (node != null)
            {
                do
                {
                    array[index++] = node.Value;
                    node = node.Next;
                } while (node != @this.Head);
            }
        }

        public DoubleLinkedListNode<T> Find<T>(DoubleLinkedList<T> @this, T value)
        {
            DoubleLinkedListNode<T> node = @this.Head;
            EqualityComparer<T> c = EqualityComparer<T>.Default;
            if (node != null)
            {
                if (value != null)
                {
                    do
                    {
                        if (c.Equals(node.Value, value))
                        {
                            return node;
                        }
                        node = node.Next;
                    } while (node != @this.Head);
                }
                else
                {
                    do
                    {
                        if (node.Value == null)
                        {
                            return node;
                        }
                        node = node.Next;
                    } while (node != @this.Head);
                }
            }
            return null;
        }

        public DoubleLinkedListNode<T> FindLast<T>(DoubleLinkedList<T> @this, T value)
        {
            if (@this.Head == null) return null;

            DoubleLinkedListNode<T> last = @this.Head.Previous;
            DoubleLinkedListNode<T> node = last;
            EqualityComparer<T> c = EqualityComparer<T>.Default;
            if (node != null)
            {
                if (value != null)
                {
                    do
                    {
                        if (c.Equals(node.Value, value))
                        {
                            return node;
                        }

                        node = node.Previous;
                    } while (node != last);
                }
                else
                {
                    do
                    {
                        if (node.Value == null)
                        {
                            return node;
                        }
                        node = node.Previous;
                    } while (node != last);
                }
            }
            return null;
        }

        public DoubleLinkedListEnumeratorApi<T> GetEnumeratorApi<T>()
        {
            return new DoubleLinkedListEnumeratorApi<T>();
        }

        public bool Remove<T>(DoubleLinkedList<T> @this, T value)
        {
            DoubleLinkedListNode<T> node = Find(@this, value);
            if (node != null)
            {
                InternalRemoveNode(@this, node);
                return true;
            }
            return false;
        }

        public void Remove<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            ValidateNode(@this, node);
            InternalRemoveNode(@this, node);
        }

        public void RemoveFirst<T>(DoubleLinkedList<T> @this)
        {
            if (@this.Head == null)
            {
                throw XExceptions.InvalidOperation.LinkedListEmpty();
            }
            InternalRemoveNode(@this, @this.Head);
        }

        public void RemoveLast<T>(DoubleLinkedList<T> @this)
        {
            if (@this.Head == null)
            {
                throw XExceptions.InvalidOperation.LinkedListEmpty();
            }
            InternalRemoveNode(@this, @this.Head.Previous);
        }

   

        public void InternalInsertNodeBefore<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, DoubleLinkedListNode<T> newNode)
        {
            newNode.Next = node;
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
            node.Previous = newNode;
            @this.Version++;
            @this.Count++;
        }

        public void InternalInsertNodeToEmptyList<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> newNode)
        {
            Debug.Assert(@this.Head == null && @this.Count == 0, "LinkedList must be empty when this method is called!");
            newNode.Next = newNode;
            newNode.Previous = newNode;
            @this.Head = newNode;
            @this.Version++;
            @this.Count++;
        }

        public void InternalRemoveNode<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            Debug.Assert(node.List == @this, "Deleting the node from another list!");
            Debug.Assert(@this.Head != null, "This method shouldn't be called on empty list!");
            if (node.Next == node)
            {
                Debug.Assert(@this.Count == 1 && @this.Head == node, "this should only be true for a list with only one node");
                @this.Head = null;
            }
            else
            {
                node.Next.Previous = node.Previous;
                node.Previous.Next = node.Next;
                if (@this.Head == node)
                {
                    @this.Head = node.Next;
                }
            }
            node.Invalidate();
            @this.Count--;
            @this.Version++;
        }

        public void ValidateNewNode<T>(DoubleLinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.List != null)
            {
                throw XExceptions.InvalidOperation.LinkedListNodeIsAttached();
            }
        }

        public void ValidateNode<T>(DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.List != @this)
            {
                throw XExceptions.InvalidOperation.ExternalLinkedListNode();
            }
        }

        public void CopyTo<T>(DoubleLinkedList<T> @this, Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Rank != 1)
            {
                
                throw XExceptions.Argument.RankMultiDimNotSupported(nameof(array));
            }

            if (array.GetLowerBound(0) != 0)
            {
                
                throw XExceptions.Argument.NonZeroLowerBound(nameof(array));
            }

            if (index < 0)
            {
                
                throw XExceptions.Argument.OutOfRange.NeedNonNegNum(nameof(index), index);
            }

            if (array.Length - index < @this.Count)
            {
                
                throw XExceptions.Argument.InsufficientSpace();
            }

            T[] tArray = array as T[];
            if (tArray != null)
            {
                CopyTo(@this, tArray, index);
            }
            else
            {
                // No need to use reflection to verify that the types are compatible because it isn't 100% correct and we can rely 
                // on the runtime validation during the cast that happens below (i.e. we will get an ArrayTypeMismatchException).
                object[] objects = array as object[];
                if (objects == null)
                {
                    
                    throw XExceptions.Argument.InvalidArrayType(nameof(array));
                }
                DoubleLinkedListNode<T> node = @this.Head;
                try
                {
                    if (node != null)
                    {
                        do
                        {
                            objects[index++] = node.Value;
                            node = node.Next;
                        } while (node !=@this.Head);
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    
                    throw XExceptions.Argument.InvalidArrayType(nameof(array));
                }
            }
        }

       
    }
}
