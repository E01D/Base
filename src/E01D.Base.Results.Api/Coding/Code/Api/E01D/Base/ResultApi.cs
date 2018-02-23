using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class ResultApi
    {
        public AddResult_I<T> CreateAdd<T>(T objectToAdd)
        {
            var result = new AddResult<T>();
            result.Data = objectToAdd;
            result.Successful = true;
            return result;
        }

        public UpdateResult_I<T> CreateUpdate<T>(T objectUpdated)
        {
            var result = new UpdateResult<T>();
            result.Data = objectUpdated;
            result.Successful = true;
            return result;
        }

        public GetResult_I<T> CreateGet<T>(T objectGet)
        {
            var result = new GetResult<T>();
            result.Data = objectGet;
            result.Successful = true;
            return result;
        }

        public GetResult_I<T> CreateGet<T>()
        {
            var result = new GetResult<T>();
            result.Data = default(T);
            result.Successful = false;
            return result;
        }
    }
}
