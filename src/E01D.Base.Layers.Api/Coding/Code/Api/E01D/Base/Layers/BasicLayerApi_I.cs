using Root.Coding.Code.Framework.E01D.Typing;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Layers
{
    [Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    public interface BasicLayerApi_I
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




        GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I;




        RemoveResult_I<T> Remove<T>(T objectToAdd)
            where T : Poco_I;




        RemoveResult_I<T> RemoveById<T>(long id)
            where T : Poco_I;




        RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I;




        UpdateResult_I<T> Update<T>(T objectToAdd)
            where T : Poco_I;

    }

    [Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    public interface BasicLayerApi_I<T>
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
        AddResult_I<T> Add(T objectToAdd)
            ;

        


        GetResult_I<T> GetById(long id)
            ;


        


        GetCollectionResult_I<T> GetAll()
            ;


        


        RemoveResult_I<T> Remove(T objectToAdd)
            ;


        


        RemoveResult_I<T> RemoveById(long id)
            ;


        


        RemoveResult_I<T> RemoveAll()
            ;


        


        UpdateResult_I<T> Update(T objectToAdd)
            ;

    }
}
