using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Code.Models.E01D.Core.IO
{
    public class BitFlagArray64: BitFlagArray
    {
        public BitFlagArray64()
        {
            Bytes = new byte[8];
        }
    }
}
