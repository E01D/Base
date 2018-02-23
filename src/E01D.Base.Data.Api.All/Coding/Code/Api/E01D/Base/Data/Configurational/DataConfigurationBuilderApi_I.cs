namespace Root.Coding.Code.Api.E01D.Base.Data.Configurational
{
    public interface DataConfigurationBuilderApi_I
    {
        void DefaultConnectionProvider<T>() where T : DataConnectionApi_I, new();
        void SetDefaultConnection(string connectionString);
    }
}
