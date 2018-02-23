using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Containers
{
    public class BasicIocContainerApi: IocContainerBaseApi<BasicIocContainer_I>, BasicIocContainerApi_I
    {
        public void Add<T>(BasicIocContainer_I container, T objectToAdd)
        {
            lock (container.SyncRoot)
            {
                var type = typeof(T);

                container.Contents.Add(type.TypeHandle, objectToAdd);
            }
        }

        public void Add(BasicIocContainer_I container, System.Type type, object objectToAdd)
        {
            lock (container.SyncRoot)
            {
                container.Contents.Add(type.TypeHandle, objectToAdd);
            }
        }

        public bool ContainsType(BasicIocContainer_I container, System.Type type)
        {
            lock (container.SyncRoot)
            {
                return container.Contents.ContainsKey(type.TypeHandle);
            }
        }
            

        public override bool Get<T>(BasicIocContainer_I container, out T result)
        {
            lock (container.SyncRoot)
            {
                var type = typeof(T);

                if (container.Contents.TryGetValue(type.TypeHandle, out object objectResult))
                {
                    result = (T) objectResult;

                    return true;
                }

                result = default(T);

                return false;
            }
        }

        public override T Get<T>(BasicIocContainer_I container)
        {
            lock (container.SyncRoot)
            {
                if (Get(container, out T result))
                {
                    return result;
                }

                return default(T);
            }
        }

        public void Reset(BasicIocContainer_I container)
        {
            lock (container.SyncRoot)
            {
                container.Contents.Clear();
            }
        }

        /// <summary>
        /// Gets an instance of an object of the type TPhenotype.  If one is not present, it creates one of type TGenotype.
        /// </summary>
        /// <typeparam name="TPhenotype"></typeparam>
        /// <typeparam name="TGenotype"></typeparam>
        /// <param name="container"></param>
        /// <returns></returns>
        public TPhenotype Get<TPhenotype, TGenotype>(BasicIocContainer_I container)
            where TGenotype:TPhenotype
        {
            lock (container.SyncRoot)
            {
                if (Get(container, out TPhenotype result))
                {
                    return result;
                }

                var objectToAdd = XNew.New<TGenotype>();

                Add(container, typeof(TPhenotype), objectToAdd);

                return objectToAdd;
            }
        }

        public bool Get<TPhenotype, TGenotype>(BasicIocContainer_I container, out TPhenotype phenotype)
            where TGenotype : TPhenotype
        {
            lock (container.SyncRoot)
            {
                if (Get(container, out TPhenotype result))
                {
                    phenotype = result;

                    return true;
                }

                var objectToAdd = XNew.New<TGenotype>();

                Add(container, typeof(TPhenotype), objectToAdd);

                phenotype = objectToAdd;

                return true;
            }
        }
    }
}
