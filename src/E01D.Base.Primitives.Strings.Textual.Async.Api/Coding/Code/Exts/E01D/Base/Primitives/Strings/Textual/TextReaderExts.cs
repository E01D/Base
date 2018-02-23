using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Primitives.Strings.Textual
{
    public static class TextReaderExts
    {
       

        public static Task<int> ReadAsync(this TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken)
        {
            XDebug.Assert(reader != null);
            return cancellationToken.IsCancellationRequested ? XAsync.Api.CancellationTokens.FromCanceled<int>(cancellationToken) : reader.ReadAsync(buffer, index, count);
        }
    }
}
