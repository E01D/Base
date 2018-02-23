using System.Data;
using System.Data.SqlClient;
using Root.Coding.Code.Api.E01D.Base.Layers.Containers;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;
using Root.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Core.Data.Sql
{
    public abstract class SqlDataApi<T> : BasicDataLayerApi<T>
        where T:Poco_I
    {
        public override void OnStore(T poco) 
        {
            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                var getResult = OnSqlSelectById(connection, poco.Id.Value);

                if (getResult.Data != null)
                {
                    OnSqlUpdate(connection, poco);
                }
                else
                {
                    OnSqlInsert(connection, poco);
                }
            }
        }

        public override AddResult_I<T> OnAdd( T objectToAdd)
        {
            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlInsert(connection, objectToAdd);
            }
        }

        public override GetCollectionResult_I<T> OnGetAll()
        {

            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlSelectAll(connection);
            }
        }

        public override GetResult_I<T> OnGetById(long id)
        {

            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlSelectById(connection, id);
            }
        }

        public override RemoveResult_I<T> OnRemove(T objectToRemove)
        {

            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlDelete(connection, objectToRemove);
            }
        }

        public override RemoveResult_I<T> OnRemoveAll()
        {

            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlDeleteAll(connection);
            }
        }

        public override RemoveResult_I<T> OnRemoveById(long id)
        {

            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlDeleteById(connection, id);
            }
        }

        public override UpdateResult_I<T> OnUpdate(T objectToUpdate)
        {

            using (SqlConnection connection = (SqlConnection)XDataBase.GetDataConnection<T>())
            {
                connection.Open();

                return OnSqlUpdate(connection, objectToUpdate);
            }
        }

        private SqlConnection GetSqlConnection(IDbConnection connection)
        {
            SqlConnection sqlConnection = connection as SqlConnection;

            if (sqlConnection == null) throw new System.Exception("Expecting SQL connection.");

            return sqlConnection;
        }

        public abstract AddResult_I<T> OnSqlInsert(SqlConnection connection, T objectToAdd);

        public abstract GetCollectionResult_I<T> OnSqlSelectAll(SqlConnection connection);

        public abstract GetResult_I<T> OnSqlSelectById(SqlConnection connection, long id);

        protected abstract RemoveResult_I<T> OnSqlDelete(SqlConnection connection, T objectToRemove);

        protected abstract RemoveResult_I<T> OnSqlDeleteAll(SqlConnection connection);

        protected abstract RemoveResult_I<T> OnSqlDeleteById(SqlConnection connection, long id);

        public abstract UpdateResult_I<T> OnSqlUpdate(SqlConnection connection, T id);
    }
}
