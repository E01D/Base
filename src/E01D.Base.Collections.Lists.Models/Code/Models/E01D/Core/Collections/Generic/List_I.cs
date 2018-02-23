namespace Root.Code.Models.E01D.Core.Collections.Generic
{
    

    public interface List_I<T> : Collection_I<T>, List_I
    {
        T[] Items { get; set; }
    }
}
