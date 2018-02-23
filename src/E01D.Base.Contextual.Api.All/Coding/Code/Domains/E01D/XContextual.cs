using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XContextual
    {
        public static ContextualApi Api { get; set; } = new ContextualApi();

        public static object CreateContext()
        {
            // Creates a new call context
            return Api.CreateContext();
        }

        /// <summary>
        /// Gets the current context object.
        /// </summary>
        /// <returns></returns>
        public static object Get()
        {
            return Api.Get();
        }

        /// <summary>
        /// Gets the current context as the type T.  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>() where T : class
        {
            return Api.Get<T>();
        }

        //public static T Get<T, TClass>() 
         
        //    where TClass:class,new()
        //{
        //    return Api.Get<T, TClass>();
        //}

        public static object GetGlobal()
        {
            return Api.GetGlobal();
        }

        public static T GetGlobal<T>() where T:class
        {
            return Api.GetGlobal<T>();
        }

        public static TPhenotype GetGlobal<TPhenotype, TGenotype>()
            where TGenotype:TPhenotype
        {
            return Api.GetGlobal<TPhenotype, TGenotype>();
        }

    }
}
