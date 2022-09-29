using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class MakeList
    {
        // uses an array to generate a sorted list of all instruments available to return in the Main program
        public static void InstrumentInventory()
        {
            string[] instrumentInventory =
            {
                    "-Fender Jazzmaster",
                    "-Fender Jaguar",
                    "-Fender Mustang",
                    "-MIA Fender Stratocaster",
                    "-MIJ Fender Stratocaster",
                    "-Gibson Les Paul",
                    "-Gretsch Electromatic 12-String",
                    "-Ibanez ArtCore",
                    "-Martin Auditorium",
                    "-Hofner Club Bass",
                    "-Fender Precision Bass",
                    "-Fender Dimension Bass",
                    "-Fender Mustang Bass",
                    "-Lanikai Ukulele",
                    "-Cordoba Ukulele",
            };
            Array.Sort(instrumentInventory);
            Console.WriteLine();
            foreach (string i in instrumentInventory)
                Console.WriteLine(i);
        }
    }
}
    

