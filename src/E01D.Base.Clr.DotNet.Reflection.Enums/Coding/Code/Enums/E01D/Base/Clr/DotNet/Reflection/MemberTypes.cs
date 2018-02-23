namespace Root.Coding.Code.Enums.E01D.Reflection
{
#if (DOTNET || PORTABLE || PORTABLE40) && !NETSTANDARD2_0
    [Flags]
    public enum MemberTypes
    {
        Event = 2,
        Field = 4,
        Method = 8,
        Property = 16
    }
#endif
}
