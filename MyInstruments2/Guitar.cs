using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class Guitar : MusicalInstrument, IPrintInstrument //--inherits from MusicalInstrument
    {
         //--this dictionary contains all guitars available to the program
        public static Dictionary<string, Guitar> guitars = new Dictionary<string, Guitar>()
        {
            { "Fender Jaguar", new Guitar() { make = "Fender", model = "Jaguar", type = "solid-body electric guitar", country = "Japan", year = 1997, serial = "A035931", color = "White", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Medium: 11-48", } },  
            { "Fender Jazzmaster", new Guitar() { make = "Fender", model = "Jazzmaster", type = "solid-body electric guitar", country = "Japan", year = 1997, serial = "A019459", color = "Sunburst", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Medium: 11-48", } },
            { "Fender Mustang", new Guitar() { make = "Fender", model = "Mustang", type = "solid-body electric guitar", country = "USA", year = 1966, serial = "118054", color = "Black", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Medium: 11-48", } },
            { "Fender Japan Stratocaster", new Guitar() { make = "Fender", model = "Stratocaster", type = "solid-body electric guitar", country = "Japan", year = 1993, serial= "P038686", color =  "Transparent Blue", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Light: 10-45", } },
            { "Fender USA Stratocaster", new Guitar() { make = "Fender", model = "Stratocaster", type = "solid-body electric guitar", country = "USA", year = 2018, serial = "US18004688", color = "Black", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Super Light: 9-41"} }, 
            { "Gibson Les Paul", new Guitar() { make = "Gibson", model = "Les Paul Studio", type = "solid-body electric guitar", country = "USA", year = 2011, serial = "133310680", color = "Walnut", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Medium: 11-48", } },
            { "Gretsch 12-String", new Guitar() { make = "Grestch", model = "G5422-12 Electromatic 12-String", type = "semi-hollow electric guitar", country = "Korea", year = 2012, serial = "K512074003", color = "Sunburst", stringBrand = "D'Addario", stringType = "Nickel Wound XL", stringGauge = "Light: 10-48", }  },
            { "Ibanez Artcore", new Guitar() { make = "Ibanez", model = "Artcore AS83", type = "semi-hollow electric guitar", country = "China", year = 2005, serial = "S05101444", color = "Tobacco Burst", stringBrand = "D'Addario", stringType = "Pure Nickel XL", stringGauge = "Medium 11-48", } },
            { "Martin Auditorium", new Guitar() { make = "Martin",model = "00016-SGT Auditorium", type = "hollow-body acoustic guitar", country = "USA", year = 2003, serial = "921955", color = "Natural Spruce", stringBrand = "D'Addario", stringType = "Phosphor Bronze", stringGauge ="Light: 12-53", } },
        };
         //--this method prints each key in the Guitar dictionary
        public override void InstrumentList()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, Guitar> pair in guitars)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }
        public void PrintInstrument()
        {
            Console.WriteLine($"Your {instrumentName} is a {type} that was made in {country} in {year}.");
            Console.WriteLine($"It is {instrumentAge} years old. It is {color} in color. Its serial number is {serial}.");
            Console.WriteLine($"It uses {instrumentString} gauge strings.");
            Console.WriteLine();
        }
    }
}
