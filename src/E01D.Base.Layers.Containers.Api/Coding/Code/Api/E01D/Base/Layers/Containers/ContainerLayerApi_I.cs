using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface ContainerLayerApi_I
    {


        /// <summary>
        /// Adds the object to the layer using the supplied context.
        /// </summary>
        /// <typeparam name="C"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="objectToAdd"></param>
        /// <returns></returns>
        AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I;




        GetResult_I<T> GetById<T>(long id)
            where T : Poco_I;




        GetCollectionResult_I<T> GetAll<C, T>()
            where T : Poco_I;




        RemoveResult_I<T> Remove<C, T>(T objectToAdd)
            where T : Poco_I;




        RemoveResult_I<T> RemoveById<C, T>(long id)
            where T : Poco_I;




        RemoveResult_I<T> RemoveAll<C, T>()
            where T : Poco_I;




        UpdateResult_I<T> Update<C, T>(T objectToAdd)
            where T : Poco_I;

    }

    public interface ContainerLayerApi_I<T>
        where T : Poco_I
    {
        


        /// <summary>
        /// Adds the object to the layer using the supplied context.
        /// </summary>
        /// <typeparam name="C"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="objectToAdd"></param>
        /// <returns></returns>
        AddResult_I<T> Add<C>(T objectToAdd)
            ;

        


        GetResult_I<T> GetById<C>(long id)
            ;


        


        GetCollectionResult_I<T> GetAll<C>(C context)
            ;


        


        RemoveResult_I<T> Remove<C>(T objectToAdd)
            ;


        


        RemoveResult_I<T> RemoveById<C>(long id)
            ;


        


        RemoveResult_I<T> RemoveAll<C>(C context)
            ;


        


        UpdateResult_I<T> Update<C>(T objectToAdd)
            ;

    }
}
