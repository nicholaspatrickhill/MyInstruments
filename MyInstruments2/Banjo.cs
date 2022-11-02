using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    public class Banjo : StringedInstrument, IMusicalInstrument 
    {
        public string Scale { get; set; }

        public static Dictionary<string, Banjo> banjos = new Dictionary<string, Banjo>
        {
            { "Vega Banjo", new Banjo() { Make = "Vega", Model = "SS-5 Folklore", Type = "open-back acoustic banjo", Country = "USA", Year = 1963,
                Serial = "A-12107", Color = "Natural Maple", Scale = "long neck", StringBrand = "John Pearse", StringType = "Nickel Wound X-Long", StringGauge = "Medium: 10-23", } },
        };

        public void ListInstruments()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, Banjo> pair in banjos)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }

        public void PrintInstrument()
        {
            Console.WriteLine($"Your {InstrumentName} is an {Type} that was made in {Country} in {Year}.");
            Console.WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It is a {Scale} instrument. Its serial number is {Serial}.");
            Console.WriteLine($"It uses {InstrumentString} gauge strings.");
            Console.WriteLine();
        }

        public void CountInstruments()
        {
            Console.WriteLine("You have " + banjos.Count + " ukuleles.");
            Console.WriteLine();
        }
    }
}
