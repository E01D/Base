using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Api.E01D.Base.Results.Fluent;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XResults
    {
        public static ResultApi Api = new ResultApi();

        public static ResultBuilderApi_I New()
        {
            throw new System.NotImplementedException();
        }

        public static AddResult_I<T> CreateAdd<T>(T objectToAdd)
        {
            return Api.CreateAdd<T>(objectToAdd);
        }

        public static UpdateResult_I<T> CreateUpdate<T>(T objectUpdated)
        {
            return Api.CreateUpdate<T>(objectUpdated);
        }

        public static GetResult_I<T> CreateGet<T>(T objectGet)
        {
            return Api.CreateGet<T>(objectGet);
        }

        public static GetResult_I<T> CreateGet<T>()
        {
            return Api.CreateGet<T>();
        }
    }
}
