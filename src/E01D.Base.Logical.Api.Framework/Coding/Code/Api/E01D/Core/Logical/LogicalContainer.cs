using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Core.Logical
{
    public class LogicalContainerApi<T> : LogicApi_I<T>
         where T : Poco_I
    {
        

        public AddResult_I<T> Add(T objectToAdd)
      
        {
            return XData.Add( objectToAdd);
        }

        

        public GetCollectionResult_I<T> GetAll()
            
        {
            return XData.GetAll<T>();
        }

        

        public GetResult_I<T> GetById(long id)
            
        {
            return XData.GetById<T>( id);
        }

        

        public RemoveResult_I<T> Remove(T objectToRemove)
            
        {
            return XData.Remove<T>( objectToRemove);
        }

        

        public RemoveResult_I<T> RemoveAll()
            
        {
            return XData.RemoveAll<T>();
        }

        

        public RemoveResult_I<T> RemoveById(long id)
            
        {
            return XData.RemoveById<T>( id);
        }

        

        public UpdateResult_I<T> Update(T objectToUpdate)
            
        {
            return XData.Update<T>( objectToUpdate);
        }
    }
}
