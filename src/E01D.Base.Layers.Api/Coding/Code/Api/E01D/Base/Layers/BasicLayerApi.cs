using System;
using E01D.Base.Layers.Exceptions.Coding.Code.Exceptions.E01D.Base.Layers;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Layers;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Layers
{
    public class BasicLayerApi
    {
        public bool GetApi<T>(LayerType layerType, out BasicLayerApi_I<T> basicLayer)
            where T : Poco_I
        {
            throw new NotImplementedException();

            //var type = typeof(T);

            //if (_.Context.Layers.Data.Apis.TryGetValue(type.TypeHandle, out object dataObject))
            //{
            //    return dataObject;
            //}

            //return null;
        }
    }

    public abstract class BasicLayerApi<TLayerType>
        where TLayerType : LayerType, new()
    {
        public TLayerType GetLayerType()
        {
            return new TLayerType();
        }

        public AddResult_I<T> Add<T>(T objectToAdd) where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, AddResult<T>, BasicLayerNotFoundException>();

            return basicLayer.Add(objectToAdd);
        }

        public GetCollectionResult_I<T> GetAll<T>() where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, GetCollectionResult<T>, BasicLayerNotFoundException>();

            return basicLayer.GetAll();
        }

        public GetResult_I<T> GetById<T>(long id) where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, GetResult<T>, BasicLayerNotFoundException>();

            return basicLayer.GetById(id);
        }

        public RemoveResult_I<T> Remove<T>(T objectToRemove) where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, RemoveResult<T>, BasicLayerNotFoundException>();

            return basicLayer.Remove(objectToRemove);
        }

        public RemoveResult_I<T> RemoveAll<T>() where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, RemoveResult<T>, BasicLayerNotFoundException>();

            return basicLayer.RemoveAll();
        }

        public RemoveResult_I<T> RemoveById<T>(long id) where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, RemoveResult<T>, BasicLayerNotFoundException>();

            return basicLayer.RemoveById(id);
        }



        public UpdateResult_I<T> Update<T>(T objectToUpdate) where T : Poco_I
        {
            BasicLayerApi_I<T> basicLayer;

            if (!XLayersBase.Api.Basic.GetApi<T>(GetLayerType(), out basicLayer))
                return XResults.New().Exception<T, UpdateResult<T>, BasicLayerNotFoundException>();

            return basicLayer.Update(objectToUpdate);
        }

        public abstract bool GetApi<T>(LayerType layerType, out BasicLayerApi_I<T> basicLayer)
            where T : Poco_I;
    }

    public abstract class BasicLayerApi<TLayerType, T>
        where TLayerType : LayerType, new()
        where T : Poco_I
    {
        public TLayerType GetLayerType()
        {
            return new TLayerType();
        }

        public AddResult_I<T> Add(T objectToAdd)
        {
            return OnAdd(objectToAdd);
        }

        public GetCollectionResult_I<T> GetAll() 
        {
            return OnGetAll();
        }

        public GetResult_I<T> GetById(long id)
        {
            return OnGetById(id);
        }

        public RemoveResult_I<T> Remove(T objectToRemove) 
        {
            return OnRemove(objectToRemove);
        }

        public RemoveResult_I<T> RemoveAll() 
        {
            return OnRemoveAll();
        }

        public RemoveResult_I<T> RemoveById(long id)
        {
            return OnRemoveById(id);
        }

        public UpdateResult_I<T> Update(T objectToUpdate) 
        {
            return OnUpdate(objectToUpdate);
        }

        public abstract AddResult_I<T> OnAdd(T objectToAdd);

        public abstract GetCollectionResult_I<T> OnGetAll();

        public abstract GetResult_I<T> OnGetById(long id);

        public abstract RemoveResult_I<T> OnRemove(T objectToRemove);

        public abstract RemoveResult_I<T> OnRemoveAll();

        public abstract RemoveResult_I<T> OnRemoveById(long id);

        public abstract UpdateResult_I<T> OnUpdate(T objectToUpdate);
    }
}
