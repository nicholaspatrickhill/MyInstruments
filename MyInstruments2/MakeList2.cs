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
        public static void InstrumentInventory2()
        {
            foreach (KeyValuePair<string, Guitar> pair in guitars)
                Console.WriteLine(pair.Key);
            foreach (KeyValuePair<string, Bass> pair in basses)
                Console.WriteLine(pair.Key);
            foreach (KeyValuePair<string, Ukulele> pair in ukuleles)
                Console.WriteLine(pair.Key);
        }
    }
}
