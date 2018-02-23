using System;
using Root.Coding.Code.Models.E01D.Base.Logging;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic
{
    public class CannotMatchQualifiedNameToClassLogMessage:LogMessageBase
    {
        private static readonly Type Type = typeof(CannotMatchQualifiedNameToClassLogMessage);

        public override Type MessageType { get; set; } = CannotMatchQualifiedNameToClassLogMessage.Type;
    }
}
