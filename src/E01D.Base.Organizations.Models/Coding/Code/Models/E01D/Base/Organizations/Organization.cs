using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Organizations
{
    public class Organization:Poco, Organization_I
    {
        public bool IsRoot { get; set; }
        public bool IsInternal { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
    }
}
