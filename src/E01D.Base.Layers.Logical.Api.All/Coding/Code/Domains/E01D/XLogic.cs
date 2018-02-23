using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XLogic
    {
        public static LogicalApiAll Api { get; set; } = new LogicalApiAll();

        public static void Add<T>(T objectToAdd)
            where T : Poco_I
        {
            XLogicContainers.Add(objectToAdd);
        }

     

        public static GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
        {
            return XLogicContainers.GetById<T>(id);
        }

        

        public static GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
        {
            return XLogicContainers.GetAll<T>();
        }

       

        public static RemoveResult_I<T> Remove<T>(T objectToRemove)
            where T : Poco_I
        {
            return XLogicContainers.Remove<T>(objectToRemove);
        }

        

        public static RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
        {
            return XLogicContainers.RemoveById<T>(id);
        }

        

        public static RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
        {
            return XLogicContainers.RemoveAll<T>();
        }

       

        public static UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
        {
            return XLogicContainers.Update<T>(objectToUpdate);
        }

        

        public static object GetApi<T>()
        {
            return Api.GetApi<T>();

        }
    }
}
