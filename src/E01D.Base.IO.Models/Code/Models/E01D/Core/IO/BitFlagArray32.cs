using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Code.Models.E01D.Core.IO
{
    public class BitFlagArray32: BitFlagArray
    {
        public BitFlagArray32()
        {
            Bytes = new byte[4];
        }
    }
}
