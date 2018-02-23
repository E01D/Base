using System;
using System.Collections.Generic;
using System.Reflection;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata
{
    public class MetadataIdentifierMapping
    {
        public Dictionary<RuntimeTypeHandle, long> TypeHandles { get; set; } = new Dictionary<RuntimeTypeHandle, long>();

        public Dictionary<Assembly, long> Assemblies { get; set; } = new Dictionary<Assembly, long>();

    }
}
