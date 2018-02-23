using Root.Code.Models.E01D.Core.Collections;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Framework.E01D;

namespace Root.Code.Apis.E01D.Core.Collections
{
    
    public class DoubleLinkedListEnumeratorApi<T>:EnumeratorApi_I<DoubleLinkedListEnumerator<T>, DoubleLinkedList<T>, T>
    {
        
        public DoubleLinkedListEnumerator<T> Create(DoubleLinkedList<T> collection)
        {
            var enumerator = new DoubleLinkedListEnumerator<T>
            {
                List = collection,
                Version = collection.Version,
                Node = collection.Head,
                Current = default(T),
                Index = 0,
                SiInfo = null
            };

            return enumerator;
        }

        public T Current(DoubleLinkedListEnumerator<T> enumerator)
        {
            
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.List.Count + 1))
            {
                throw XExceptions.InvalidOperation.EnumOpCantHappen();

                
            }

            return enumerator.Current;
            
        }

        public void Dispose(DoubleLinkedListEnumerator<T> enumerator)
        {
            enumerator.Current = default(T);
            enumerator.List = null;
        }

        public bool MoveNext(DoubleLinkedListEnumerator<T> enumerator)
        {
            if (enumerator.Version != enumerator.List.Version)
            {
                throw XExceptions.InvalidOperation.EnumFailedVersion();
            }

            if (enumerator.Node == null)
            {
                enumerator.Index = enumerator.List.Count + 1;
                return false;
            }

            ++enumerator.Index;
            enumerator.Current = enumerator.Node.Value;
            enumerator.Node = enumerator.Node.Next;
            if (enumerator.Node == enumerator.List.Head)
            {
                enumerator.Node = null;
            }
            return true;
        }

        public void Reset(DoubleLinkedListEnumerator<T> enumerator)
        {
            if (enumerator.Version != enumerator.List.Version)
            {
                throw XExceptions.InvalidOperation.EnumFailedVersion();
            }

            enumerator.Current = default(T);
            enumerator.Node = enumerator.List.Head;
            enumerator.Index = 0;
        }

        

        
    }
}
