using System;
using Root.Coding.Code.Domains.E01D;



namespace Root.Coding.Code.Exts.E01D.Core
{
    public static class ExceptionExts
    {
        public static string GetFullMessage(this System.Exception exception)
        {
            return XExceptions.Api.GetFullMessage(exception);
        }

        public static string GetStackTraces(this Exception exception)
        {
            throw new NotImplementedException();
            //return Core.Exceptions.GetStackTraces(exception);
        }
    }
}
