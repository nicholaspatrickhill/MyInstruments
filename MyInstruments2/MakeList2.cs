using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments2.Ukulele;
using static MyInstruments2.Guitar;
using static MyInstruments2.Bass;

namespace MyInstruments2
{
    internal class MakeList2
    {
         //--this method prints each key from each dictionary as one master list
        public static void InstrumentInventory2()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();

            guitar.InstrumentList();
            bass.InstrumentList();
            ukulele.InstrumentList();
        }
    }
}
