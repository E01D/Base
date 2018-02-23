using Root.Coding.Code.Api.E01D.Core.Data;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Data.Containers
{
    /// <summary>
    /// Represents a data container that supports querying.
    /// </summary>
    public interface QueryableDataContainerApi_I<T>: DataContainerApi_I<T>
    {
        GetCollectionResult_I<T> Query(T queryByExample);

        GetCollectionResult_I<T> Query(Query_I query);
    }
}
