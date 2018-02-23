using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Root.Coding.Code.Models.E01D.Base.Consoles;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ConsoleApi
    {
        

        public void WaitForAcknowledgement(int timeoutMilliseconds)
        {
            ReadLine(out string input, timeoutMilliseconds);
        }

        public bool ReadLine(out string input, int timeoutMilliseconds = Timeout.Infinite)
        {
            ReadLineState state = new ReadLineState()
            {
                GetInputEvent = new ManualResetEvent(false),
                GotInputEvent = new ManualResetEvent(false),
                InputThread = new Thread(ReadLoop)
                {
                    IsBackground = true
                }
            };

            state.InputThread.Start(state);

            // Trigger ReadLine();
            state.GetInputEvent.Set();

            var successful = state.GotInputEvent.WaitOne(timeoutMilliseconds);

            if (successful)
            {
                input = state.Input;
                return true;
            }

            input = null;

            return false;
        }

        public void ReadLoop(object stateObject)
        {
            ReadLineState state = (ReadLineState)stateObject;

            while (true)
            {
                state.GetInputEvent.WaitOne();
                state.Input = Console.ReadLine();
                state.GotInputEvent.Set();
            }
        }
    }
}
