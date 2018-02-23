using System.Globalization;
using Root.Coding.Code.Attributes.E01D.Json;
using Root.Coding.Code.Enums.E01D.Core.DateTimes;
using Root.Coding.Code.Enums.Javascript.Strings;

namespace Root.Coding.Code.Models.E01D.Json.Writing
{
    public class JsonWriterInternal
    {
        // It's not safe to perform the async methods here in a derived class as if the synchronous equivalent
        // has been overriden then the asychronous method will no longer be doing the same operation.
#if HAVE_ASYNC // Double-check this isn't included inappropriately.
        public bool SafeAsync { get; set; }
#endif

        public Formatting Formatting { get; set; }
        public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
        public StringEscapeHandling StringEscapeHandling { get; set; }
        public FloatFormatHandling FloatFormatHandling { get; set; }
        public CultureInfo Culture { get; set; }
    }
}
