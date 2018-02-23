using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Data.Containers
{
    /// <summary>
    /// Represents a general data container that contains objects of type T that can be queried, accept new objects, have objects removed, and have objects updated.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface DataContainerApi_I<T>
    {
        AddResult_I<T> Add<C>(T objectToAdd);



        GetCollectionResult_I<T> GetAll<C>();

        


        GetResult_I<T> GetById<C>(long id);



        RemoveResult_I<T> Remove<C>(T objectToRemove);



        RemoveResult_I<T> RemoveAll<C>();



        RemoveResult_I<T> RemoveById<C>(long id);

        UpdateResult_I<T> Update(T objectToUpdate);
    }
}
