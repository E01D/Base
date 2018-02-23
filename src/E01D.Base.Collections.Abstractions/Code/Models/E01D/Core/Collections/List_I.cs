namespace Root.Code.Models.E01D.Core.Collections
{
    public interface List_I : Collection_I
    {
        bool IsReadOnly { get; }

        bool IsFixedSize { get; }
    }
}
