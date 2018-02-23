using E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XData
    {
        public static DataSystemApi_I Api { get; set; } = new DataSystemApi();

        /// <summary>
        /// Used to add an object of type T to a data source without having to know where the data source is located or how to access the data source.
        /// </summary>
        /// <typeparam name="T">The type of object to add.</typeparam>
        /// <param name="objectToAdd">The object to be added to the database</param>
        /// <returns>Returns the result of the add operation.</returns>
        public static AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I
        {
            return Api.Layers.Basic.Add(objectToAdd);
        }

     
        /// <summary>
        /// Used to get an object by id of type T from a data source wihtout having to know where the data source is located or how to access the data source.
        /// </summary>
        /// <typeparam name="T">The type of object to get</typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public static GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
        {
            return Api.Layers.Basic.GetById<T>(id);
        }


        /// <summary>
        /// Used to get all objects of of type T from a data source wihtout having to know where the data source is located or how to access the data source.
        /// </summary>
        /// /// <typeparam name="T">The type of object to get</typeparam>
        public static GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
        {
            return Api.Layers.Basic.GetAll<T>();
        }


        /// <summary>
        /// Used to get remove all objects of of type T from a data source wihtout having to know where the data source is located or how to access the data source.
        /// </summary>
        /// /// <typeparam name="T">The type of object to remove</typeparam>
        public static RemoveResult_I<T> Remove<T>(T objectToRemove)
            where T : Poco_I
            
        {
            return Api.Layers.Basic.Remove<T>(objectToRemove);
        }


        /// <summary>
        /// Used to get remove an object of type T with the specified id from a data source wihtout having to know where the data source is located or how to access the data source.
        /// </summary>
        /// /// <typeparam name="T">The type of object to remove</typeparam>
        public static RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
            
        {
            return Api.Layers.Basic.RemoveById<T>(id);
        }


        /// <summary>
        /// Used to get remove all objects of type T with the specified id from a data source without having to know where the data source is located or how to access the data source.
        /// </summary>
        public static RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
            
        {
            return Api.Layers.Basic.RemoveAll<T>();
        }

        /// <summary>
        /// Used to get update an object of type T with the specified id from a data source wihtout having to know where the data source is located or how to access the data source.
        /// </summary>
        public static UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
            
        {
            return Api.Layers.Basic.Update<T>(objectToUpdate);
        }

        public static bool IsInitialized()
        {
            return false;
        }

        /// <summary>
        /// Gets the appropriate data api for the type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static object GetApi<T>()
        {
            return Api.GetApi<T>();
        }

        public static DataLayerApi_I GetApiForModel<TModel>()
        {
            return Api.GetApiForModel<TModel>();
        }

        public static void LoadApis()
        {
            Api.LoadApis();
        }

        public static void Store<T>(T poco) where T:Poco_I
        {
            var api = GetApiForModel<T>();

            switch (api.Kind)
            {
                case Enums.E01D.Base.Data.DataLayerKind.Basic:
                {
                    var basicApi = (BasicDataLayerApi_I<T>)api;

                    basicApi.Store(poco);

                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
}
