using Root.Coding.Code.Framework.E01D;
using Root.Coding.Code.Models.E01D.Base.Types;
using Root.Coding.Code.Models.E01D.Base.Values;

namespace Root.Coding.Code.Models.E01D.Base.Pocos
{
    public abstract class PocoValue<T>:Valued<T>, Typed_I
    {
        public TypeId_I TypeId { get; set; }
    }
}
