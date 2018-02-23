using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Primitives.Arrays
{
    public static class ArrayExts
    {
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            return XArrays.Api.Slice(source, start, end);
            
        }

        public static void TaReverse<T>(this T[] array)
        {
            XArrays.Api.TaReverse(array);
        }
    }
}
