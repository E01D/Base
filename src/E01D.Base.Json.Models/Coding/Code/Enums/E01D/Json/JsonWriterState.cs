namespace Root.Coding.Code.Enums.E01D.Json
{
    public enum JsonWriterState
    {
        Start = 0,
        Property = 1,
        ObjectStart = 2,
        Object = 3,
        ArrayStart = 4,
        Array = 5,
        ConstructorStart = 6,
        Constructor = 7,
        Closed = 8,
        Error = 9
    }
}
