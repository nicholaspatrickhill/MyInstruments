using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;
using static MyInstruments.MusicalInstrument;

namespace MyInstruments
{
    public class InstrumentText : MusicalInstrument
    {
        public void PrintInstrument()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();

            Console.WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            Console.WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. Its serial number is {Serial}.");
            Console.WriteLine($"It uses {InstrumentString} gauge strings.");
            Console.WriteLine();
        }
    }
}
