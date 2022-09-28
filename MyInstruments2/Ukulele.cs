using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyInstruments2
{
    public class Ukulele : MusicalInstrument
    {
        public string Size { get; set; }
        public static void Ukes()
        {
            Dictionary<string, Ukulele> ukuleles = new Dictionary<string, Ukulele>()
            {
                { "Lanikai", new Ukulele() { Make = "Lanikai", Model = "LU-11", Type = "hollow-body acoustic", Country = "China", Year = 2012, Serial = "Y31107", Color = "Natural Nato", Size = "Soprano",  } },
                { "Cordoba", new Ukulele() { Make = "Cordoba", Model = "20-TMCE", Type = "hollow-body acoustic", Country = "China", Year = 2017, Serial = "41638150", Color = "Natural Mahogany", Size = "Tenor",} },
            };
        }
    }
}

