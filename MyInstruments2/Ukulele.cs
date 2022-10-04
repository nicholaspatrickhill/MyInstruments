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
    public class Ukulele : MusicalInstrument, IPrintInstrument //--inherits from Musical Instrument and implements the IPrintInstrument interface
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
            Console.WriteLine();
            foreach (KeyValuePair<string, Ukulele> pair in ukuleles)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }
         //--implements the IPrintInstrument interface, provides the unique body for the PrintInstrument method
        public void PrintInstrument()
        {
            Console.WriteLine($"Your {instrumentName} is a {type} that was made in {country} in {year}.");
            Console.WriteLine($"It is {instrumentAge} years old. It is {color} in color. It is a {size} sized instrument. Its serial number is {serial}.");
            Console.WriteLine();
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

