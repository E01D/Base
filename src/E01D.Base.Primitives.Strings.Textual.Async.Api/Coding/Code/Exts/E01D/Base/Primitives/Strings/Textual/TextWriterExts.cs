using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Primitives.Strings.Textual
{
    public static class TextWriterExts
    {
        public static Task WriteAsync(this TextWriter writer, char value, CancellationToken cancellationToken)
        {
            XDebug.Assert(writer != null);
            return cancellationToken.IsCancellationRequested ? XAsync.Api.CancellationTokens.FromCanceled(cancellationToken) : writer.WriteAsync(value);
        }

        public static Task WriteAsync(this TextWriter writer, string value, CancellationToken cancellationToken)
        {
            XDebug.Assert(writer != null);
            return cancellationToken.IsCancellationRequested ? XAsync.Api.CancellationTokens.FromCanceled(cancellationToken) : writer.WriteAsync(value);
        }

        public static Task WriteAsync(this TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken)
        {
            XDebug.Assert(writer != null);
            return cancellationToken.IsCancellationRequested ? XAsync.Api.CancellationTokens.FromCanceled(cancellationToken) : writer.WriteAsync(value, start, count);
        }
    }
}
