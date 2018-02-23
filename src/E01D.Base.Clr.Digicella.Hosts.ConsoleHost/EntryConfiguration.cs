using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01D.Base.Clr.Digicella.Hosts.ConsoleHost
{
    public class EntryConfiguration
    {
        public string[] CommandLineArguments { get; set; }

        public string LocalPath { get; set; }

        public bool WaitForDebugger { get; set; }

        public bool Verbose { get; set; }
        
    }
}
