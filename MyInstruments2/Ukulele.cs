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
        public string Size { get; set; }

         //--this dictionary contains all ukuleles available to the program
        public static Dictionary<string, Ukulele> ukuleles = new Dictionary<string, Ukulele>
        {
            { "Cordoba Ukulele", new Ukulele() { Make = "Cordoba", Model = "20-TMCE", Type = "hollow-body acoustic ukulele", Country = "China", Year = 2017, Serial = "41638150", Color = "Natural Mahogany", Size = "tenor", } },
            { "Lanikai Ukulele", new Ukulele() { Make = "Lanikai", Model = "LU-11", Type = "hollow-body acoustic ukulele", Country = "China", Year = 2012, Serial = "Y31107", Color = "Natural Nato", Size = "soprano", } },
        };
         //--this method prints each key in the Ukulele dictionary
        public override void InstrumentList()
        {
            foreach (KeyValuePair<string, Ukulele> pair in ukuleles)
                Console.WriteLine(pair.Key);
        }
    }
}

