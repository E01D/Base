

using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Organizations
{
    public interface Organization_I:Poco_I
    {
        bool IsRoot { get; set; }
        bool IsInternal { get; set; }
        string Name { get; set; }
        long ParentId { get; set; }
    }
}
