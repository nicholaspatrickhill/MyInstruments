using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class MakeList
    {
        public static void InstrumentInventory()
        {
            string[] instrumentInventory =
            {
                    "-Fender Jazzmaster",
                    "-Fender Jaguar",
                    "-USA Fender Stratocaster",
                    "-Japan Fender Stratocaster",
                    "-Hofner Club",
                    "-Fender Precision Bass"
                    };
            Array.Sort(instrumentInventory);
            foreach (string i in instrumentInventory)
                Console.WriteLine(i);
        }
    }
}
    

