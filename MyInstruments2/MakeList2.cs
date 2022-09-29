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
            Guitar.GuitarList();
            Bass.BassList();
            Ukulele.UkuleleList();
        }
    }
}
