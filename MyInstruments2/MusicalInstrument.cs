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
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public string? Country { get; set; }
        public int Year { get; set; }

        public string? Serial { get; set; }
        public string? Color { get; set; }

        public string? InstrumentName
        {
            get
            {
                return Make + " " + Model;
            }
        }

        public int InstrumentAge
        {
            get
            {
                return (DateTime.Now.Year - Year);
            }
        }
    }
}
