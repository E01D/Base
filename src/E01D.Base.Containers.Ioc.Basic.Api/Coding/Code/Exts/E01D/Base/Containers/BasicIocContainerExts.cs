

using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Containers
{
    
    public static class BasicIocContainerExts
    {
        public static void Add<T>(this BasicIocContainer_I container, T objectToAdd)
        {
            XBasicIoc.Add<T>(container, objectToAdd);
        }
        public static void Add(this BasicIocContainer_I container, System.Type type, object objectToAdd)
        {
            XBasicIoc.Add(container, type, objectToAdd);
        }

        public static bool ContainsType(this BasicIocContainer_I container, System.Type type)
        {
            return XBasicIoc.ContainsType(container, type);
        }


        public static T Get<T>(this BasicIocContainer_I container)
        {
            return XBasicIoc.Get<T>(container);
        }

        public static TPhenotype Get<TPhenotype, TGenotype>(this BasicIocContainer_I container)
            where TGenotype:TPhenotype
        {
            return XBasicIoc.Get<TPhenotype, TGenotype>(container);
        }

        public static bool Get<TPhenotype, TGenotype>(this BasicIocContainer_I container, out TPhenotype phenotype)
            where TGenotype : TPhenotype
        {
            return XBasicIoc.Get<TPhenotype, TGenotype>(container, out phenotype);
        }

        public static bool Get<T>(this BasicIocContainer_I container, out T result)
        {
            return XBasicIoc.Get<T>(container, out result);
        }

        public static T GetService<T>(this BasicIocContainer_I container)
        {
            return XBasicIoc.GetService<T>(container);
        }

        public static void Reset(this BasicIocContainer_I container)
        {
            XBasicIoc.Reset(container);
        }
    }
}
