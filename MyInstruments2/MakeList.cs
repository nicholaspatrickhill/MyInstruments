using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class MakeList
    {
        // uses an array to generate a list of all instruments available to return in the Main program
        public static void InstrumentInventory()
        {
            string[] instrumentInventory =
            {
                    "-Fender Jazzmaster",
                    "-Fender Jaguar",
                    "-MIA Fender Stratocaster",
                    "-MIJ Fender Stratocaster",
                    "-Hofner Club",
                    "-Fender Precision Bass",
                    };
            Array.Sort(instrumentInventory);
            Console.WriteLine();
            foreach (string i in instrumentInventory)
                Console.WriteLine(i);
        }
    }
}
    

