using Root.Coding.Code.Models.E01D.Base.Pocos;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Layers.Containers
{
    public interface LogicContainerApi_I
    {
        AddResult_I<T> Add<T>(T objectToAdd)
            where T : Poco_I;

        GetResult_I<T> GetById<T>(long id)
            where T : Poco_I;

        GetCollectionResult_I<T> GetAll<T>()
            where T : Poco_I;


        RemoveResult_I<T> Remove<T>(T objectToAdd)
            where T : Poco_I;

        RemoveResult_I<T> RemoveAll<T>()
            where T : Poco_I;

        UpdateResult_I<T> Update<T>(T objectToAdd)
            where T : Poco_I;
    }
}
