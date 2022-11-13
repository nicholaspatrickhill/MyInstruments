namespace MyInstruments
{
    public abstract class StringInstrument : MusicalInstrument
    {
        public string? StringBrand { get; set; }
        public string? StringType { get; set; }
        public string? StringGauge { get; set; }
        public string? InstrumentString
        {
            get
            {
                return StringBrand + " " + StringType + " " + StringGauge;
            }
        }
    }
}
