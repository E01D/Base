using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Layers.Containers
{
    public abstract class DataContainerApi<T>
    {
        public AddResult_I<T> Add<C>(T objectToAdd)
        {
            return OnAdd(objectToAdd);
        }



        public GetCollectionResult_I<T> GetAll<C>()

        {
            return OnGetAll();
        }



        public GetResult_I<T> GetById<C>(long id)

        {
            return OnGetById(id);
        }



        public RemoveResult_I<T> Remove<C>(T objectToRemove)

        {
            return OnRemove(objectToRemove);
        }



        public RemoveResult_I<T> RemoveAll<C>()

        {
            return OnRemoveAll();
        }



        public RemoveResult_I<T> RemoveById<C>(long id)

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
