namespace Root.Coding.Code.Api.E01D.Base.NetFramework
{
    public class ToStringApi
    {
        /// <summary>
        /// Provides a default ToString implementation for classes that choose to override the default .NET method
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public string Convert(object @this)
        {
            var s = @this as string;

            if (s != null)
            {
                return s;
            }

            return @this.ToString();

            //return @this?.GetType().FullName ?? string.Empty;
        }
    }
}
