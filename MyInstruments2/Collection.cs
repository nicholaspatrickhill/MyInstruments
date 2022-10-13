using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;

namespace MyInstruments
{
    class Collection
    {
        public static void CountAll()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();

            int num1 = guitars.Count;
            int num2 = basses.Count;
            int num3 = ukuleles.Count;
            int num4 = num1 + num2 + num3;

            Console.WriteLine("You have " + num4 + " total instruments in your collection.");
            Console.WriteLine();
        }

        public static void ListAll()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();

            Console.WriteLine();
            Console.WriteLine("Guitars:");
            guitar.ListInstruments();
            Console.WriteLine("Basses:");
            bass.ListInstruments();
            Console.WriteLine("Ukuleles:");
            ukulele.ListInstruments();
        }
    }
}
