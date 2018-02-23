using System;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata;

namespace Root.Coding.Code.Api.E01D.Base.Cli
{
    public class MetadataApi
    {
        public RuntimeTypeHandle TypeHandle(MetadataBase_I type)
        {
            return (RuntimeTypeHandle?)type.RuntimeMapping ?? default(RuntimeTypeHandle);
        }
    }
}
