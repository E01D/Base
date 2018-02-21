namespace Root.Coding.Code.Models.E01D.Base.Values
{
    public class Valued<T>: Valued_I<T>
    {
        object Valued_I.Value => Value;
        public T Value { get; set; }
    }

    public class Valued : Valued_I
    {
        public object Value { get; set; }
    }
}
