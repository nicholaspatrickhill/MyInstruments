using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public abstract class MusicalInstrument
    {
        public string make { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string country { get; set; }
        public int year { get; set; }

        public string serial { get; set; }
        public string color { get; set; }
        public string stringBrand { get; set; }
        public string stringType { get; set; }
        public string stringGauge { get; set; }

         //--combines the Make and Model for simpler code in Main
        public string instrumentName
        {
            get
            {
                return make + " " + model;
            }
        }

         //--calculates the instrument's age by subtracting the instrument's year of manufacture from the current year
        public int instrumentAge
        {
            get
            {
                return (DateTime.Now.Year - year);
            }
        }

         //--combines the string Brand, Type and gauge for simpler code in Main
        public string instrumentString
        {
            get
            {
                return stringBrand + " " + stringType + " " + stringGauge;
            }
        }

         //--abstract method to generate lists of each key in the dictionaries
        public abstract void InstrumentList(); 
    }
}
