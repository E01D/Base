using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;

namespace Root.Coding.Code.Api.E01D.Base.Containers
{
    public interface BasicIocContainerApi_I:IocContainerBaseApi_I<BasicIocContainer_I>
    {
        void Add<T>(BasicIocContainer_I container, T objectToAdd);

        void Add(BasicIocContainer_I container, System.Type type, object objectToAdd);

        bool ContainsType(BasicIocContainer_I container, System.Type type);


        void Reset(BasicIocContainer_I container);

        TPhenotype Get<TPhenotype, TGenotype>(BasicIocContainer_I container)
            where TGenotype : TPhenotype;

        bool Get<TPhenotype, TGenotype>(BasicIocContainer_I container, out TPhenotype phenotype)
            where TGenotype : TPhenotype;
    }
}
