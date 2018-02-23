
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Security.Authorization
{
    public interface Permission_I:Poco_I
    {
        long SourceOrganizationId { get; set; }
    }
}
