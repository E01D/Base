namespace Root.Coding.Code.Models.E01D.Base.Values
{
    public interface Valued_I<T>: Valued_I
    {
        new T Value { get; set; }
    }

    public interface Valued_I
    {
        object Value { get; }
    }
}
