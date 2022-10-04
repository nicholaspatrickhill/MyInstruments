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
    internal class MakeList
    {
         //--this method prints each key from each dictionary as one master list
        public static void InstrumentInventory()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();

            Console.WriteLine();
            Console.WriteLine("Guitars:");
            guitar.InstrumentList();
            Console.WriteLine();
            Console.WriteLine("Basses:");
            bass.InstrumentList();
            Console.WriteLine();
            Console.WriteLine("Ukuleles:");
            ukulele.InstrumentList();
            Console.WriteLine();
        }
    }
}
