using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    public abstract class StringedInstrument : MusicalInstrument
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
