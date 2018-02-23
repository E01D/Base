using Root.Coding.Code.Api.E01D.Base.Identification.Factories;
using Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Booting;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class BootApi
    {
        public BootApi Boot()
        {
            OnBoot();

            return this;
        }

        public BootApi Boot(string[] args)
        {
            OnBoot();

            return this;
        }

        public BootApi Boot<TStartup>() where TStartup : Startup_I
        {
            OnBoot();

            return this;
        }

        public BootApi Boot<TStartup>(string[] args) where TStartup : Startup_I
        {
            OnBoot();

            return this;
        }

        public void OnBoot()
        {
            // Given the settings have been setup, the identification system can load. 
            XIdentification.Initialize();

            if (XNew.Api.Factory is ObjectFactoryApi)
            {
                // Change the object factory to look for types that implement Ided_I and set the identifier.
                XNew.Api.Factory = new IdentificationObjectFactory();
            }

            //XTypal.Initialize();

            // We want to enable as many systems as possible to be able to be setup dynamically.  A type scan is needed. To identify dynamic components  
            // The type scan needs to ultimately build a semantic model, and this model requires th use of identifiers.  This is to enable it to 
            // house runtime types and types that are not yet built in the same model.  This was change from the first version.
            XReflection.Api.Scanning.IO.ScanEntryAssemblyDirectoryForAssemblies();
            

            //// load data before logic to prevent logics from being called without data present.
            XData.LoadApis();

            

            //XLogic.LoadApis();

            //LoadLogicApis();

            //if (_.Instance.Associations == null)
            //{
            //    _.Instance.Associations = new AssociationApi();
            //}

            //// With the logic and data types identified via the logic and data apis, the typas can be created.
            //EnsureLogicDataTypes();

            //var context = _.CreateContext();

            //_.StartOperation(context);

            //// Phase 2 Type load
            //XTypal.EnsureTypasAreStored(context);

            //CreateSqlStatementsForDataTypas();  // nothign was there before
        }

        //private void EnsureLogicDataTypes()
        //{
        //    var logicTypeKeys = _.Context.Layers.Logic.Apis.Keys.ToList();

        //    for (int i = 0; i < logicTypeKeys.Count; i++)
        //    {
        //        System.Type type = System.Type.GetTypeFromHandle(logicTypeKeys[i]);

        //        var typa = XTypal.GetTypa(type);
        //    }

        //    var dataTypeKeys = _.Context.Layers.Data.Apis.Keys.ToList();

        //    for (int i = 0; i < dataTypeKeys.Count; i++)
        //    {
        //        System.Type type = System.Type.GetTypeFromHandle(dataTypeKeys[i]);

        //        var typa = XTypal.GetTypa(type);
        //    }
        //}

       

        //private void LoadLogicApis()
        //{
        //    var typex = typeof(LogicApi_I<>);

        //    var dictionary = _.Context.Layers.Logic.Apis;

        //    LoadApis(typex, dictionary);

        //    LoadAttributedApis(typeof(LogicApiAttribute), dictionary);
        //}

        


    }
}
