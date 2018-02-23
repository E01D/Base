using Root.Code.Api.E01D.Core.Transceiving.Transceivers;

namespace Root.Code.Api.E01D.Core.Transceiving
{
    public class TranceiverApi
    {
        public BoolApi Bool { get; set; } = new BoolApi();

        public Int64Api Int64 { get; set; } = new Int64Api();

        public Int32Api Int32 { get; set; } = new Int32Api();

        public Int16Api Int16 { get; set; } = new Int16Api();

        public Int08Api Int08 { get; set; } = new Int08Api();

        public UInt64Api UInt64 { get; set; } = new UInt64Api();

        public UInt32Api UInt32 { get; set; } = new UInt32Api();

        public UInt16Api UInt16 { get; set; } = new UInt16Api();

        public UInt08Api UInt08 { get; set; } = new UInt08Api();

        public DateTimeApi DateTime { get; set; } = new DateTimeApi();

        public TimeSpanApi Timespan { get; set; } = new TimeSpanApi();

        public CharApi Char { get; set; } = new CharApi();

        public StringApi String { get; set; } = new StringApi();
    }
}
