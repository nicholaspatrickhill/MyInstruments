using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class ZeroInput
    {
        // this method is not working as intended yet. i want it to change my 0 values recorded for year to the text "unknown." 
        public static void YearConversion()
        {
            var musicalInstrument = new MusicalInstrument();
            if (musicalInstrument.Year == 0);
            {
                Convert.ToString(musicalInstrument.Year);

                string oldValue = musicalInstrument.Year.ToString();

                string newValue = musicalInstrument.Year.ToString().Replace("0", "unknown");                
            }
        }
    }
}