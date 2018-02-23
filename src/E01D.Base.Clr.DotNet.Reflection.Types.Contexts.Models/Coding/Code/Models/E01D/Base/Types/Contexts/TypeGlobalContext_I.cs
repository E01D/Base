using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Types.Contexts
{
    public interface TypeGlobalContext_I
    {
        Dictionary<long, System.RuntimeTypeHandle> TypeHandles { get; }

        Dictionary<System.RuntimeTypeHandle, TypeId_I> TypeIdsByTypeHandle { get; }
        object SyncRoot { get; set; }
        TypeId_I StandardTypeIdTypeId { get; set; }
    }
}
