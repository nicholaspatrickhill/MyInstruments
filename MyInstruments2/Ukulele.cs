using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments2.CheckInstruments;

namespace MyInstruments2
{
    public class Ukulele : MusicalInstrument //--inherits from Musical Instrument
    {
        public string size { get; set; }

         //--this dictionary contains all ukuleles available to the program
        public static Dictionary<string, Ukulele> ukuleles = new Dictionary<string, Ukulele>
        {
            { "Cordoba Ukulele", new Ukulele() { make = "Cordoba", model = "20-TMCE", type = "hollow-body acoustic ukulele", country = "China", year = 2017, serial = "41638150", color = "Natural Mahogany", size = "tenor", } },
            { "Lanikai Ukulele", new Ukulele() { make = "Lanikai", model = "LU-11", type = "hollow-body acoustic ukulele", country = "China", year = 2012, serial = "Y31107", color = "Natural Nato", size = "soprano", } },
        };
         //--this method prints each key in the Ukulele dictionary
        public override void InstrumentList()
        {
            foreach (KeyValuePair<string, Ukulele> pair in ukuleles)
                Console.WriteLine(pair.Key);
        }
        /*public static void AddUkulele(Ukulele)
        {
            Console.WriteLine("Please type the keyword for the instrument you'd like to add (ex. \"Fender Telecaster\".)");
            var ukulele = new Ukulele();
            string input = Console.ReadLine();
            ukuleles.Add(input, value: ukulele);
        }*/
    }
}

