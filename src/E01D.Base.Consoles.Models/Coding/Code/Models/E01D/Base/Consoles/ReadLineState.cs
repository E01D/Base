using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Base.Consoles
{
    public class ReadLineState
    {
        public Thread InputThread { get; set; }
        public ManualResetEvent GetInputEvent { get; set; }
        public ManualResetEvent GotInputEvent { get; set; }
        public string Input { get; set; }
    }
}
