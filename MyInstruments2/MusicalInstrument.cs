using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    public abstract class MusicalInstrument
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }

        public string Serial { get; set; }
        public string Color { get; set; }
        public string StringBrand { get; set; }
        public string StringType { get; set; }
        public string StringGauge { get; set; }

        public string InstrumentName
        {
            get
            {
                return Make + " " + Model;
            }
        }

        // Fulfills Feature List Requirement: "Calculate and display data based on an external factor"
        // Calculates the instrument's age by subtracting the instrument's year of manufacture from the current year
        public int InstrumentAge
        {
            get
            {
                return (DateTime.Now.Year - Year);
            }
        }

        public string InstrumentString
        {
            get
            {
                return StringBrand + " " + StringType + " " + StringGauge;
            }
        }
    }
}
