namespace Root.Coding.Code.Api.E01D.Core
{
    public class ArrayApi
    {
        // We impose limits on maximum array lenght in each dimension to allow efficient 
        // implementation of advanced range check elimination in future.
        // Keep in sync with vm\gcscan.cpp and HashHelpers.MaxPrimeArrayLength.
        // The constants are defined in this method: inline SIZE_T MaxArrayLength(SIZE_T componentSize) from gcscan
        // We have different max sizes for arrays with elements of size 1 for backwards compatibility
        public int MaxArrayLength { get; set; } = 0X7FEFFFFF;
    }
}
