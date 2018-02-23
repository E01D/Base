using System;
using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public class JsonContract
    {
        public JsonReadType InternalReadType { get; set; }

        public bool IsNullable { get; set; }
        public bool IsConvertable { get; set; }
        public bool IsEnum { get; set; }
        public Type NonNullableUnderlyingType { get; set; }

        public JsonContractType ContractType { get; set; }
        public bool IsReadOnlyOrFixedSize { get; set; }
        public bool IsSealed { get; set; }
        public bool IsInstantiable { get; set; }

        /// <summary>
        /// Gets the underlying type for the contract.
        /// </summary>
        /// <value>The underlying type for the contract.</value>
        public Type UnderlyingType { get; set; }
    }
}
