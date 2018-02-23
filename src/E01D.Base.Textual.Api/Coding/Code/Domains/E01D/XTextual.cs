using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Api.E01D.Base.Textual;

namespace Root.Coding.Code.Domains.E01D
{
    public class XTextual
    {
        public static TextualApi Api { get; set; } = new TextualApi();

        public static TextSegmentApi TextSegments { get; set; } = new TextSegmentApi();

        public static TextSourceApi TextSources { get; set; } = new TextSourceApi();

        public static string StripNulls(string input)
        {
            return Api.StripNulls(input);
        }
    }
}
