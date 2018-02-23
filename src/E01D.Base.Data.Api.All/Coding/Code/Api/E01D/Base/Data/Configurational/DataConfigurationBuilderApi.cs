using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Data.Contexts;

namespace Root.Coding.Code.Api.E01D.Base.Data.Configurational
{
    public class DataConfigurationBuilderApi: DataConfigurationBuilderApi_I
    {
        public void DefaultConnectionProvider<T>() where T : DataConnectionApi_I, new()
        {
            var context = XContextual.GetGlobal<DataGlobalContext_I>();

            context.DefaultDataConnectionProvider = new T();
        }

        public void SetDefaultConnection(string connectionString)
        {
            var context = XContextual.GetGlobal<DataGlobalContext_I>();

            context.DefaultConnectionString = connectionString;
        }
    }
}
