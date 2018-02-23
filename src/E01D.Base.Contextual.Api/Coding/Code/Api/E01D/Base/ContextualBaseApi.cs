using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Base.Containers;
using Root.Coding.Code.Models.E01D.Base.Contextual;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ContextualBaseApi: ContextualBaseApi_I
    {

        public object Get()
        {
            var localContext = ContextualGlobals.Contexts.Value;

            return localContext?.Context;
        }

        public T Get<T>()
        {
            var localContext = ContextualGlobals.Contexts.Value;

            if (!localContext.Contexts.Get<T>(out T context))
            {
                return default(T);
            }

            return context;
        }

        public T Get<T, TClass>() where TClass : T, new()
        {
            var localContext = ContextualGlobals.Contexts.Value;

            if (!localContext.Contexts.Get<T, TClass>(out T context))
            {
                return default(T);
            }

            return context;
        }

        public void Set(object contextValue)
        {
            if (ContextualGlobals.Contexts.Value == null)
            {
                ContextualGlobals.Contexts.Value = new LocalContext();
            }

            ContextualGlobals.Contexts.Value.Contexts.Reset();

            ContextualGlobals.Contexts.Value.Context = contextValue;

            var dictionary = ContextualGlobals.Contexts.Value.Contexts;

            FillInContextTable(contextValue, dictionary);
        }

        public TPhenotype GetGlobal<TPhenotype, TGenotype>()
            where TGenotype:TPhenotype
        {
            return ContextualGlobals.GlobalContexts.Get<TPhenotype, TGenotype>();
        }

        public T GetAs<T>() where T:class
        {
            return Get() as T;
        }

        public object GetGlobal()
        {
            return ContextualGlobals.GlobalContext;
        }

        public T GetGlobalAs<T>() where T : class
        {
            return GetGlobal() as T;
        }

        public void Dispose()
        {
            if (ContextualGlobals.Contexts?.Value == null)
            {
                return;
            }

            ContextualGlobals.Contexts.Value = null;
        }

        public T GetGlobal<T>()
        {
            if (!ContextualGlobals.GlobalContexts.Get<T>(out T context))
            {
                return default(T);
            }

            return context;
        }

        public void SetGlobal(object globalContext)
        {
            ContextualGlobals.GlobalContexts.Reset();

            ContextualGlobals.GlobalContext = globalContext;

            var dictionary = ContextualGlobals.GlobalContexts;

            FillInContextTable(globalContext, dictionary);
        }

        public void FillInContextTable(object context, BasicIocContainer_I container)
        {
            if (context == null) return;

            var propertyValues = XTypesBasic.GetAllPropertyValues(context);

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < propertyValues.Length; i++)
            {
                var propertyValue = propertyValues[i];

                if (propertyValue == null) continue;

                var type = propertyValue.PropertyType;

                var propertyObjectValue = propertyValue.Value;

                if (!container.ContainsType(type))
                {
                    container.Add(type, propertyObjectValue);
                }
            }
        }
    }
}
