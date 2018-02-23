using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XVersionId
    {
        public static VersionId_I New(object castToLong)
        {
            return XPocos.Api.NewVersionId(castToLong);
        }

        public static VersionId_I New()
        {
            return XPocos.Api.NewVersionId();
        }
    }
}
