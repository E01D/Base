using System;
using System.Collections.Generic;

namespace Root.Coding.Code.Api.E01D.Base.Containers.Ioc
{
    public interface BasicIocContainer_I:IocContainer_I
    {
        object SyncRoot { get; }
        Dictionary<RuntimeTypeHandle, object> Contents { get; set; }
    }
}
