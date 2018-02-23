using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings;

namespace Root.Coding.Code.Exts.E01D.Strings
{
    public static class StringReferenceExts
    {
        public static string ConvertToString(this StringReference stringReference)
        {
            return XStrings.Api.StringReferences.ConvertToString(stringReference);
        }

        public static char Get(this StringReference stringReference, int i)
        {
            return XStrings.Api.StringReferences.Get(stringReference, i);
        }

        public static int IndexOf(this StringReference s, char c, int startIndex, int length)
        {
            return XStrings.Api.StringReferences.IndexOf(s, c, startIndex, length);
        }

        public static bool StartsWith(this StringReference s, string text)
        {
            return XStrings.Api.StringReferences.StartsWith(s, text);
        }

        public static bool EndsWith(this StringReference s, string text)
        {
            return XStrings.Api.StringReferences.EndsWith(s, text);
        }
    }
}
