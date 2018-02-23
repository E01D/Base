using System;
using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Api.E01D.Base.Configurational.Settings.Building;
using Root.Coding.Code.Api.E01D.Base.Data;
using Root.Coding.Code.Api.E01D.Base.Data.Configurational;
using Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Booting;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ConfigurationalApiAll
    {
        public BootApi Boot()
        {
            return XBooting.Boot();
        }

        public BootApi Boot(string[] args)
        {
            return XBooting.Boot(args);
        }

        public BootApi Boot<TStartup>() where TStartup : Startup_I
        {
            return XBooting.Boot<TStartup>();
        }

        public BootApi Boot<TStartup>(string[] args) where TStartup : Startup_I
        {
            return XBooting.Boot<TStartup>(args);
        }

        public ConfigurationalApiAll Data(Action<DataConfigurationBuilderApi_I> action)
        {
            DataConfigurationBuilderApi_I api = XData.Api.Configurational.Builder;

            action(api);

            return this;
        }

        public ConfigurationalApiAll Settings(Action<SettingBuilderApi_I> settingScript)
        {
            SettingBuilderApi_I api = new SettingBuilderApi();

            settingScript(api);

            return this;
        }

        public ConfigurationalApiAll UseContext(object globalContext)
        {
            XConfigurationalBase.Api.UseContext(globalContext);

            return this;
        }

        public ConfigurationalApiAll UseStandardContext()
        {
            XConfigurationalBase.Api.UseStandardContext();

            return this;
        }

        public ConfigurationalApiAll UseObjectFactory(ObjectFactoryApi_I objectFactory)
        {
            XConfigurationalBase.Api.UseObjectFactory(objectFactory);

            return this;
        }

        public ConfigurationalApiAll UseData(DataSystemApi_I data)
        {
            XConfigurationalBase.Api.UseData(data);

            return this;
        }

        public ConfigurationalApiAll UseDataConnectionProvider<TProvider>(string configurationString)
            where TProvider : DataConnectionApi_I, new()
        {
            XConfigurationalBase.Api.UseDataConnectionProvider<TProvider>(configurationString);

            return this;
        }



        public ConfigurationalApiAll UseTypeLoader<T>() where T : TypeLoaderApi_I
        {
            XConfigurationalBase.Api.UseTypeLoader<T>();

            return this;
        }

        public ConfigurationalApiAll UseTypeLoader<T>(string connectionString) where T : TypeLoaderApi_I
        {
            XConfigurationalBase.Api.UseTypeLoader<T>(connectionString);

            return this;
        }





        //public ConfigurationalApiAll UseSettings<TProvider>(string connectionString) where TProvider : SettingProviderApi_I, new()
        //{
        //    XConfigurationalBase.Api.UseSettings<TProvider>(connectionString);

        //    return this;
        //}


        //public void Settings(Action<SettingConfigurationApi> action)
        //{
        //    throw new NotImplementedException();
        //}
        
    }
}
