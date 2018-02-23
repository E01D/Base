namespace Root.Coding.Code.Api.E01D.Core
{
    public class CastingApi
    {
        public T CastOrThrow<T>(object x) where T:class
        {
            if (x == null) return null;

            var result = x as T;

            if (result == null)
            {
                throw new System.Exception($"Cannot cast type {x.GetType().FullName} to {typeof(T).FullName}");
            }

            return result;
        }
    }
}
