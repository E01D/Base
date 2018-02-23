using System.Data.SqlClient;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Data.Contexts;

namespace Root.Coding.Code.Api.E01D.Base.Data.Sql.SqlServer
{
    public class SqlServerDataConnectionApi: DataConnectionApi_I
    {
        public object CreateConnection<T>()
        {
            var context = XContextual.GetGlobal<DataGlobalContext_I>();

            return new SqlConnection(context.DefaultConnectionString);
        }
    }
}
