using Root.Code.Api.E01D.Core.Data.Sql;
using Root.Coding.Code.Models.E01D.Base.Configurational.Data;

namespace Root.Code.Domains.E01D
{
    public class XConnectionStrings
    {
        public static ConnectionStringApi Api { get; set; } = new ConnectionStringApi();

        public static ConnectionString_I Create(string connectionString)
        {
            return Api.Create(connectionString);
        }

        public static ConnectionString_I Create(string server, string database, string userId, string password)
        {
            return Api.Create(server, database, userId, password);
        }

        public static ConnectionStringContext_I CreateContext(string server, string database, string userId, string password)
        {
            return Api.CreateContext(server, database, userId, password);
        }

        public static string CreateString(string server, string database, string userId, string password)
        {
            return Api.CreateString(server, database, userId, password);
        }
    }
}
