using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class MusicalInstrument
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public string Serial { get; set; }
        public string Color { get; set; }

        /// combines the Make and Model for simpler code in Main
        public string InstrumentName
        {
            get
            {
                return Make + " " + Model;
            }
        }
        /// calculates the instrument's age by subtracting the instrument's year of manufacture from the current year
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }


    }
}