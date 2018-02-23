using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Primitives.Bool
{
    public static class BoolExts
    {
        public static Task<bool> ToAsync(this bool value) => XAsync.Api.ToAsync(value);
    }
}
