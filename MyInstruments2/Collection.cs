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
    class Collection
    {
        public static void CountAll()
        {
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

        public static void CountInstrument(Guitar guitar, Bass bass, Ukulele ukulele, string input)
        {
            if (input == "Count Guitars")
            {
                guitar.CountInstruments();
            }
            else if (input == "Count Basses")
            {
                bass.CountInstruments();
            }
            else if (input == "Count Ukuleles")
            {
                ukulele.CountInstruments();
            }
        }

        public static void ListInstrument(Guitar guitar, Bass bass, Ukulele ukulele, string input)
        {
            if (input == "Guitars")
            {
                guitar.ListInstruments();
            }
            else if (input == "Basses")
            {
                bass.ListInstruments();
            }
            else if (input == "Ukuleles")
            {
                ukulele.ListInstruments();
            }
        }
    }
}
