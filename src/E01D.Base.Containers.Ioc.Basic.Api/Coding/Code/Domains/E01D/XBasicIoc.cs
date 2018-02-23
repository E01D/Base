using System;
using Root.Coding.Code.Api.E01D.Base.Containers;
using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XBasicIoc
    {
        public static BasicIocContainerApi_I Api { get; set; } = new BasicIocContainerApi();

        public static void Add<T>(BasicIocContainer_I container, T objectToAdd)
        {
            Api.Add<T>(container, objectToAdd);
        }

        public static void Add(BasicIocContainer_I container, System.Type type, object objectToAdd)
        {
            Api.Add(container, type, objectToAdd);
        }

        public static bool ContainsType(BasicIocContainer_I container, System.Type type)
        {
            return Api.ContainsType(container, type);
        }

        public static T Get<T>(BasicIocContainer_I container)
        {
            return Api.Get<T>(container);
        }

        public static bool Get<T>(BasicIocContainer_I container, out T result)
        {
            return Api.Get<T>(container, out result);
        }

        public static TPhenotype Get<TPhenotype, TGenotype>(BasicIocContainer_I container)
            where TGenotype:TPhenotype
        {
            return Api.Get<TPhenotype, TGenotype>(container);
        }

        public static bool Get<TPhenotype, TGenotype>(BasicIocContainer_I container, out TPhenotype phenotype)
            where TGenotype : TPhenotype
        {
            return Api.Get<TPhenotype, TGenotype>(container, out phenotype);
        }

        public static T GetService<T>(BasicIocContainer_I container)
        {
            return Api.GetService<T>(container);
        }

        public static void Reset(BasicIocContainer_I container)
        {
            Api.Reset(container);
        }
    }
}
