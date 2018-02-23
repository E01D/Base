using System.Data;
using Root.Coding.Code.Models.E01D.Core.Data;

namespace Root.Coding.Code.ModelProviders.E01D.Core.Data
{
    public interface DbConnectionProvider_I
    {
        IDbConnection Get(DataContainerContext context);
    }
}
