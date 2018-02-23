namespace Root.Coding.Code.Framework.E01D
{
    public interface EnumeratorApi_I<TEnumerator, in TCollection, out TItem>
    {
        TEnumerator Create(TCollection collection);

        TItem Current(TEnumerator enumerator);

        bool MoveNext(TEnumerator enumerator);

        void Reset(TEnumerator enumerator);

        void Dispose(TEnumerator enumerator);
    }
}
