﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Ukulele;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;

namespace MyInstruments
{
    public class InstrumentInventory
    {
         //--this method prints each key from each dictionary as one master list
        public static void ListInstruments()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();

            Console.WriteLine();
            Console.WriteLine("Guitars:");
            guitar.InstrumentList();
            Console.WriteLine("Basses:");
            bass.InstrumentList();
            Console.WriteLine("Ukuleles:");
            ukulele.InstrumentList();
        }
    }
}
