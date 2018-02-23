using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Base
{
    public interface DebugContext_I
    {
        bool IsAttached { get; }

        bool IsConsoleEnabled { get; set; }

        bool IsEnabled { get; set; }
    }
}
