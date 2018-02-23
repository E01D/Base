using System;
using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Api.E01D.Base.Containers.Ioc
{
    public class BasicIocContainer:BasicIocContainer_I
    {
        public Dictionary<RuntimeTypeHandle, object> Contents { get; set; } = new Dictionary<RuntimeTypeHandle, object>();

        public Id_I Id { get; set; }

        public object SyncRoot { get; } = new object();

        public TypeId_I TypeId { get; set; }
        
    }
}
