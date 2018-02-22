// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See: https://github.com/dotnet/corert/blob/master/src/System.Private.CoreLib/src/System/Array.CoreRT.cs

namespace Root.Coding.Code.Constants.E01D.Base
{
    public class ArrayConsts
    {
        // We impose limits on maximum array lenght in each dimension to allow efficient 
        // implementation of advanced range check elimination in future.
        // Keep in sync with vm\gcscan.cpp and HashHelpers.MaxPrimeArrayLength.
        // The constants are defined in this method: inline SIZE_T MaxArrayLength(SIZE_T componentSize) from gcscan
        // We have different max sizes for arrays with elements of size 1 for backwards compatibility
        public const int MaxArrayLength = 0X7FEFFFFF;
        public const int MaxByteArrayLength = 0x7FFFFFC7;
    }
}
