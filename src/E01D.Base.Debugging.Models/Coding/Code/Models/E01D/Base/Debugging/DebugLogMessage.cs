using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Models.E01D.Base.Logging;

namespace Root.Coding.Code.Models.E01D.Base.Debugging
{
    public class DebugLogMessage:LogMessageBase
    {
        private static readonly Type Type = typeof(DebugLogMessage);

        public override Type MessageType { get; set; } = DebugLogMessage.Type;
    }
}
