namespace Root.Coding.Code.Enums.E01D.Rest
{
    /// <summary>
    /// A part of a call.
    /// </summary>
    public enum CallComponentType
    {
        Unknown = 0,
        Cookie = 1,
        GetOrPost = 2,
        HttpHeader = 3,
        QueryString = 4,
        RequestBody = 5,
        UrlSegment =6,
    }
}
