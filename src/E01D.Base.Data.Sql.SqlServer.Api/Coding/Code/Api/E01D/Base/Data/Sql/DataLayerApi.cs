using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers
{
    /// <summary>
    /// 
    /// </summary>
    /// <designNotes>Due to needing security, permissions and exceptions, this logic needs to be moved to its own assembly, and added by the E01D booter.</designNotes>
    public class DataLayerApi:DataLayerApi_I
    {
        public AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Containers.Data.Apis.TryGetValue(objectToAdd.TypaId, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.Add(objectToAdd);
            //}

            //return new AddResult<T>()
            //{
            //    Successful = false
            //};
        }

        

        public GetResult_I<T> GetById<T>(long id)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.GetById(id);
            //}

            //return new GetResult<T>()
            //{
            //    Successful = false
            //};
        }

        

        public GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.GetAll();
            //}

            //return new GetCollectionResult<T>()
            //{
            //    Successful = false
            //};
        }

        

        public RemoveResult_I<T> Remove<T>(T objectToRemove)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.Remove(objectToRemove);
            //}

            //return new RemoveResult<T>()
            //{
            //    Successful = false
            //};
        }

        

        public RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.RemoveById(id);
            //}

            //return new RemoveResult<T>()
            //{
            //    Successful = false
            //};
        }

        

        public RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.RemoveAll();
            //}

            //return new RemoveResult<T>()
            //{
            //    Successful = false
            //};
        }

        

        public UpdateResult_I<T> Update<T>(T objectToUpdate)
            where T : Poco_I
        {
            throw new System.NotImplementedException();
            //var type = typeof(T);

            //if (XLayers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    DataApi_I<T> dataApi = (DataApi_I<T>)dataObject;

            //    return dataApi.Update(objectToUpdate);
            //}

            //return new UpdateResult<T>()
            //{
            //    Successful = false
            //};
        }

        
    }
}
