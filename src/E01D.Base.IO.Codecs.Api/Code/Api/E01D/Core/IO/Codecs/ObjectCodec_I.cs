using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs
{
    public interface ObjectCodec_I
    {
        object Read(Block_I block);

        void Write(Block_I block, object value);

        object Read(byte[] block, int position);

        void Write(byte[] block, int position, object value);
    }
}
