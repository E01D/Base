using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XLogicBase
    {
        public static LogicalApi Api { get; set; } = new LogicalApi();


        public static object GetApi<T>()
        {
            return Api.GetApi<T>();

        }

        public static object GetApi(TypeId_I typeId)
        {
            return Api.GetApi(typeId);
        }
    }
}
