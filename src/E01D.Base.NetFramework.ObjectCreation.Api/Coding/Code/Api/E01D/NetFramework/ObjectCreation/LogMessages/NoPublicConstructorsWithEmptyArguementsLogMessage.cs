using System;
using Root.Coding.Code.Models.E01D.Base.Logging;

namespace Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation.LogMessages
{
    public class NoPublicConstructorsWithEmptyArguementsLogMessage:LogMessageBase
    {
        private static readonly Type Type = typeof(NoPublicConstructorsWithEmptyArguementsLogMessage);

        public override Type MessageType { get; set; } = Type;
    }
}
