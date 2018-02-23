using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XContextualBase
    {
        public static ContextualBaseApi Api { get; set; } = new ContextualBaseApi();

        

        /// <summary>
        /// Gets the current context object.
        /// </summary>
        /// <returns></returns>
        public static object Get()
        {
            return Api.Get();
        }

        public static T Get<T>()
        {
            return Api.Get<T>();
        }

        public static T Get<T, TClass>()
            where TClass:class, T, new()
        {
            return Api.Get<T, TClass>();
        }

        /// <summary>
        /// Gets the current context as the type T.  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetAs<T>() where T:class
        {
            return Api.GetAs<T>();
        }

        public static object GetGlobal()
        {
            return Api.GetGlobal();
        }

        public static T GetGlobal<T>()
        {
            return Api.GetGlobal<T>();
        }

        public static TPhenotype GetGlobal<TPhenotype, TGenotype>()
           where TGenotype:TPhenotype
        {
            return Api.GetGlobal<TPhenotype, TGenotype>();
        }

        public static T GetGlobalAs<T>() where T:class
        {
            return Api.GetGlobalAs<T>();
        }

        public static void Dispose()
        {
            Api.Dispose();
        }

        public static void Set(object contextValue)
        {
            Api.Set(contextValue);
        }

        public static void SetGlobal(object globalContext)
        {
            Api.SetGlobal(globalContext);
        }
    }
}
