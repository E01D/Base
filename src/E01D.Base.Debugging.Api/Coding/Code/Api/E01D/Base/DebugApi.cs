using System;
using E01D.Base.Debugging.Enums.Coding.Code.Enums.E01D.Base.Debugging;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Debugging;
using Root.Coding.Code.Models.E01D.Base.Messaging.Messages;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class DebugApi: DebugApi_I
    {
        

        public bool Assert(bool condition)
        {
            return Assert(condition, null);

            
        }

        public bool Assert(bool condition, string message)
        {
            if (condition) return true;

            OnFail(message, AssertionHandlingMethod.Throw);

            return false;
        }

        public bool Assert(bool condition, AssertionHandlingMethod method, string message)
        {
            if (condition) return true;

            OnFail(message, method);

            return false;
        }

        

        public void OnFail(string message, AssertionHandlingMethod method)
        {
            switch (method)
            {
                case AssertionHandlingMethod.Console:
                {
                    Console.WriteLine(message);
                    return;
                }
                case AssertionHandlingMethod.Log:
                {
                    XLog.LogError(new DebugLogMessage()
                    {
                        Message = new Message()
                        {
                            Value = message
                        }
                    });

                    return;
                }
                case AssertionHandlingMethod.Throw:
                {
                    throw XExceptions.Exception(message);
                }
                default:
                {
                    Console.WriteLine(method);
                    return;
                }
            }
        }

        public void WriteLine(string line)
        {
            var context = XContextualBase.GetAs<DebugContextHost_I>();

            if (!context.Debug.IsEnabled) return;

            XLog.LogDebug(new DebugLogMessage()
            {
                Message = new Message()
                {
                    Value = line
                }
            });

            System.Diagnostics.Debug.WriteLine(line);

            if (context.Debug.IsConsoleEnabled) // useful when writing test cases
            {
                Console.WriteLine(line);
            }
        }

        
    }
}
