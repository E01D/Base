using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Primitives.Strings.Base64Encoding;

namespace Root.Coding.Code.Exts.E01D.Strings.Base64Encoding
{
    public static class Base64EncoderExts
    {
        public static void Encode(this Base64Encoder encoder, byte[] buffer, int index, int count)
        {
            XBase64Encoding.Api.Encode(encoder, buffer, index, count);
        }

        public static void Flush(this Base64Encoder encoder)
        {
            XBase64Encoding.Api.Flush(encoder);
        }
    }
}
