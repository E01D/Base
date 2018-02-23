using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Api.E01D.Base.Data;
using Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ConfigurationalApi
    {
        

        public ConfigurationalApi UseContext(object globalContext)
        {
            // Sets the global context.  In most cases this context should inherit from the StandardGlobalContext as it would provide most of the default systems.  
            XContextualBase.SetGlobal(globalContext);

            return this;
        }

        public ConfigurationalApi UseStandardContext()
        {
            return UseContext(new StandardGlobalContext());   
        }

        public ConfigurationalApi UseObjectFactory(ObjectFactoryApi_I objectFactory)
        {
            XNew.Api.Factory = objectFactory;

            return this;
        }

        public ConfigurationalApi UseData(DataSystemApi_I data)
        {
            throw new System.NotImplementedException();
            //_.Instance.Data = data;

            //return this;
        }

        public ConfigurationalApi UseDataConnectionProvider<TProvider>(string configurationString)
            where TProvider : DataConnectionApi_I, new()
        {
            throw new System.NotImplementedException();
            //if (_.Instance.Data == null) return this;

            //_.Instance.Data.Connections = new TProvider();

            //_.Context.Layers.Data.ConfigurationString = configurationString;

            //return this;
        }



        public ConfigurationalApi UseTypeLoader<T>() where T : TypeLoaderApi_I
        {
            //TypalContextHost_I context = _.ContextAs<TypalContextHost_I>();

            //context.Typal.TypeLoading.TypeLoader = (TypeLoaderApi_I)_.New<T>();

            //return this;
            throw new System.NotImplementedException();
        }

        public ConfigurationalApi UseTypeLoader<T>(string connectionString) where T : TypeLoaderApi_I
        {
            throw new System.NotImplementedException();
            //TypalGlobalContextHost_I context = _.ContextAs<TypalContextHost_I>();

            //context.Typal.TypeLoading.ConnectionString = connectionString;

            //context.Typal.TypeLoading.TypeLoader = XNew.New<T>();

            //return this;
        }





        //public ConfigurationalApi UseSettings<TProvider>(string connectionString) where TProvider : SettingProviderApi_I, new()
        //{
        //    XSettings.Setup<TProvider>();

        //    if (!string.IsNullOrEmpty(connectionString))
        //    {
        //        XSettings.Connect(connectionString);
        //    }

        //    return this;
        //}








    }
}
