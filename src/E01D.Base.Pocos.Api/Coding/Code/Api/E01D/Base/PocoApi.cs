using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class PocoApi
    {
        public VersionId_I NewVersionId(object castToLong)
        {
            return new VersionId()
            {
                Value = (long)castToLong
            };
        }

        public VersionId_I NewVersionId()
        {
            var id =  new VersionId()
            {
                
            };

            XIdentification.IssueId(id);

            return id;
        }
    }
}
