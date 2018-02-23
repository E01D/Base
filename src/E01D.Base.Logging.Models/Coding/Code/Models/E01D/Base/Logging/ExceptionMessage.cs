using System;

namespace Root.Coding.Code.Models.E01D.Base.Logging
{
    public class ExceptionMessage<TException> : LogMessageBase
        where TException:System.Exception
    {
        

        public override Type MessageType { get; set; } = typeof(TException);
    }
}
