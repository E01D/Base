using System;
using Root.Coding.Code.Api.E01D.Base.Contextual;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ContextualApi: ContextualApi_I
    {
        public object CreateContext()
        {
            return Factory?.Create();
        }

        public ContextFactory_I Factory { get; set; } = new ContextFactoryApi();


        public object Get()
        {
            return XContextualBase.Get();
        }

        public T Get<T>() where T:class
        {
            return XContextualBase.Get<T>();
        }

        public T Get<T, TClass>() 
            where TClass:class,T, new()
        {
            return XContextualBase.Get<T, TClass>();
        }

        public object GetGlobal()
        {
            return XContextualBase.GetGlobal();
        }

        public TPhenotype GetGlobal<TPhenotype>() where TPhenotype : class
        {
            return XContextualBase.GetGlobal<TPhenotype>();
        }

        public TPhenotype GetGlobal<TPhenotype, TGenotype>()
            where TGenotype:TPhenotype
        {
            return XContextualBase.GetGlobal<TPhenotype, TGenotype>();
        }
    }
}
