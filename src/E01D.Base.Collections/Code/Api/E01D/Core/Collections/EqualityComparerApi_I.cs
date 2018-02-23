namespace Root.Code.Api.E01D.Core.Collections
{
    public interface EqualityComparerApi_I
    {
        bool Equals(object x, object y);

        int GetHashCode(object obj);
    }
}
