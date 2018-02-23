using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs
{
    /// <summary>
    /// Provides a generic interface to read and write objects to and from a stream.
    /// </summary>
    public interface Codec_I<T>:ObjectCodec_I
    {
        T Read(Block_I block);

        T Read(byte[] bytes, int offset);

        void Write(Block_I block, T value);

        void Write(byte[] bytes, int offset, T value);


    }
}
