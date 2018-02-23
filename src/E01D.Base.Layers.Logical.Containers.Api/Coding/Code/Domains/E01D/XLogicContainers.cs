using Root.Coding.Code.Api.E01D.Base.Layers.Containers;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XLogicContainers
    {
        public static LogicContainerLayerSystemApi Api { get; set; } = new LogicContainerLayerSystemApi();

        public static AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I
        {
            return Api.Add(objectToAdd);
        }



        public static GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
        {
            return Api.GetById<T>(id);
        }



        public static GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
        {
            return Api.GetAll<T>();
        }



        public static RemoveResult_I<T> Remove<T>(T objectToRemove)
            where T : Poco_I
        {
            return Api.Remove<T>(objectToRemove);
        }



        public static RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
        {
            return Api.RemoveById<T>(id);
        }



        public static RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
        {
            return Api.RemoveAll<T>();
        }



        public static UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
        {
            return Api.Update<T>(objectToUpdate);
        }
    }
}
