namespace Root.Coding.Code.Enums.E01D.Json.Bson
{
    public enum BsonReaderState
    {
        Normal = 0,
        ReferenceStart = 1,
        ReferenceRef = 2,
        ReferenceId = 3,
        CodeWScopeStart = 4,
        CodeWScopeCode = 5,
        CodeWScopeScope = 6,
        CodeWScopeScopeObject = 7,
        CodeWScopeScopeEnd = 8
    }
}
