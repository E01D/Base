using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Types.Contexts
{
    public class TypeGlobalContext: TypeGlobalContext_I
    {
        public Dictionary<long, System.RuntimeTypeHandle> TypeHandles { get; set; } = new Dictionary<long, System.RuntimeTypeHandle>();

        public Dictionary<System.RuntimeTypeHandle, TypeId_I> TypeIdsByTypeHandle { get; set; } = new Dictionary<System.RuntimeTypeHandle, TypeId_I>();
        public object SyncRoot { get; set; } = new object();
        public TypeId_I StandardTypeIdTypeId { get; set; }
    }
}
