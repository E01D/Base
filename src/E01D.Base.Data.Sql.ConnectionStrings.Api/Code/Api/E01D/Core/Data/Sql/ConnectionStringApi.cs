using Root.Coding.Code.Models.E01D.Base.Configurational.Data;

namespace Root.Code.Api.E01D.Core.Data.Sql
{
    public class ConnectionStringApi
    {
        public string CreateString(string server, string database, string userId, string password)
        {
            return $@"Server={server};Database={database};User Id={userId};Password={password};";
        }

        public ConnectionString_I Create(string server, string database, string userId, string password)
        {
            var connectionString = new ConnectionString()
            {
                Value = CreateString(server, database, userId, password)
            };

            return connectionString;
        }

        public ConnectionString_I Create(string connectionString)
        {
            return new ConnectionString()
            {
                Value = connectionString
            };
        }

        public ConnectionStringContext_I CreateContext(string server, string database, string userId, string password)
        {
            var context = new ConnectionStringContext()
            {
                ActiveConnectionString = Create(server, database, userId, password)
            };

            return context;
        }
    }
}
