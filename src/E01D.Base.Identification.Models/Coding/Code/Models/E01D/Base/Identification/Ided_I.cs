using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public interface Ided_I: Typed_I
    {
        Id_I Id { get; set; }
    }
}
