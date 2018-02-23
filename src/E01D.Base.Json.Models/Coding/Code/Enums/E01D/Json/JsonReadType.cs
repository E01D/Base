namespace Root.Coding.Code.Enums.E01D.Json
{
    public enum JsonReadType
    {
        Read,
        ReadAsInt32,
        ReadAsInt64,
        ReadAsBytes,
        ReadAsString,
        ReadAsDecimal,
        ReadAsDateTime,
#if HAVE_DATE_TIME_OFFSET
        ReadAsDateTimeOffset,
#endif
        ReadAsDouble,
        ReadAsBoolean
    }
}
