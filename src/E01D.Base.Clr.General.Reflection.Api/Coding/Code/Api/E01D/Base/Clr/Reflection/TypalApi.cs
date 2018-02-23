using Root.Coding.Code.Api.E01D.Base.Clr.Reflection.Typal;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Framework.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.Reflection
{
    public class TypalApi
    {
        ///// <summary>
        ///// Gets or sets the api used to scan assemblies, modules and types.
        ///// </summary>
        //public ScanningApi Scanning => XTypalScanning.Api;

        //public TypesApi Types => XTypalTypes.Api;
        public LibraryApi Library { get; set; } = new LibraryApi();

        public TypeLoaderApi_I TypeLoader()
        {
            
            //TypalContextHost_I context = _.ContextAs<TypalContextHost_I>();

            //return context?.Typal?.TypeLoading?.TypeLoader;

            throw new System.NotImplementedException();

        }

        /// <summary>
        /// Initializes the 
        /// </summary>
        public void Initialize()
        {
            //TypeLoader.LoadStoredTypes();

            //var typaType = typeof(Typa);

            //var typaTypa = Library.GetTypa(typaType);

            //TypalContextHost_I context = _.ContextAs<TypalContextHost_I>();

            //context.Typal.Typa = typaTypa;

        }

        [TransactionBoundary] // TODO: Need to inject logic
        public void EnsureTypasAreStored()
        {
            //object context;

            //_.PerformOp(context, (innerContext) =>
            //{
            //    var typas = Library.GetAll();

            //    for (int i = 0; i < typas.Length; i++)
            //    {
            //        var typa = typas[i] as Typa;

            //        if (typa == null) continue;

            //        // Need to have has id operation as it will only hit the object table
            //        if (XData.GetById<Context_I, Typa>(context, typa.Id).Data == null)
            //        {
            //            XData.Add(context, typa);
            //        }


            //    }
            //});
        }
    }
}
