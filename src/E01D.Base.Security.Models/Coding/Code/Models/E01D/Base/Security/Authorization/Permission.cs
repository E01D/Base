using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Security.Authorization
{
    
    public class Permission:Poco, Permission_I
    {
        public long SourceOrganizationId { get; set; }
    }
}
