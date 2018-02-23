using Root.Coding.Code.Domains.E01D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D.Base;
using Root.Coding.Code.Enums.E01D.Base.Logging;

namespace E01D.Base.Clr.Digicella.Hosts.ConsoleHost
{
    class Program
    {
        // https://github.com/dotnet/coreclr/blob/master/src/coreclr/hosts/coreconsole/coreconsole.cpp
        private static int Main(string[] args)
        {
            EntryConfiguration configuration = new EntryConfiguration();

            var localpath = XAssembliesBase.GetEntryAssemblyLocalPath();

            if (localpath == null)
            {
                XLogBase.LogCritical("Failed to get the path to the current executable.");
                XConsole.Api.WaitForAcknowledgement(5000); // https://stackoverflow.com/questions/57615/how-to-add-a-timeout-to-console-readline
                return -1;
            }

            char[] extension = null; //XIO.GetExtensionAsArray(localpath, Case.Lower); // Case.Default, Case.Unknown, Case.Upper

            extension[1] = 'd';
            extension[2] = 'l';
            extension[3] = 'l';

            bool verbose = false;
            bool waitForDebugger;
            bool helpRequested = false;

            if (helpRequested)
            {
                ShowHelp();
                return -1;
            }
            else
            {
                if (verbose)
                {
                    XLog.SetLogLevel(LogLevels.Trace);
                }

                ProgramResult result = TryRun(configuration);

                if (result.Successful)
                {
                    Console.WriteLine("Execution succeeded");

                    return 0;
                }
                else
                {
                    Console.WriteLine("Execution failed.");

                    return -1;
                }
            }

            
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Runs executables on CoreCLR\r\n");
		    Console.WriteLine("\r\n");
		    Console.WriteLine("USAGE: <program>.exe [/_d] [/_v]\r\n");
		    Console.WriteLine("\r\n");
		    Console.WriteLine("  Runs <program>.dll managed program on CoreCLR.\r\n");
		    Console.WriteLine("        /_v causes verbose output to be written to the console.\r\n");
		    Console.WriteLine("        /_d causes the process to wait for a debugger to attach before starting.\r\n");
		    Console.WriteLine("\r\n");
		    Console.WriteLine("  CoreCLR is searched for in %%core_root%%, then in the directory that this executable is in.\r\n");
		    Console.WriteLine("  The program dll needs to be in the same directory as this executable.\r\n");
		    Console.WriteLine("  The program dll needs to have main entry point.\r\n");
		
        }

        private static ProgramResult TryRun(EntryConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
