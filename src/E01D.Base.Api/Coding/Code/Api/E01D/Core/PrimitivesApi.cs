using Root.Coding.Code.Api.E01D.Core.Primitives;

namespace Root.Coding.Code.Api.E01D.Core
{
    public class PrimitivesApi
    {
        public StringApi String { get; set; } = new StringApi();

        public DateTimeApi DateTime { get; set; } = new DateTimeApi();

        public SingleApi Single { get; set; } = new SingleApi();

        public DoubleApi Double { get; set; } = new DoubleApi();

        public Int32Api Int32 { get; set; } = new Int32Api();

        public BoolApi Bool { get; set; } = new BoolApi();

        public bool IsNumeric(object value)
        {
            return  value is int || value is uint
                || value is long || value is ulong
                || value is float || value is double
                || value is decimal
                || value is short || value is ushort
                || value is sbyte || value is byte;
        }
    }
}
