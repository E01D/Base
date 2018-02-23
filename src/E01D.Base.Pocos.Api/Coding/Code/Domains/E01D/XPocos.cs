using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XPocos
    {
        public static PocoApi Api { get; set; } = new PocoApi();

        public static VersionId_I NewVersionId(object castToLong)
        {
            return Api.NewVersionId(castToLong);
        }
    }
}
