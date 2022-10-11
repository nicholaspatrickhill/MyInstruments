using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.InstrumentText;

namespace MyInstruments
{
    public class Guitar : MusicalInstrument, IDictionaryMethods
    //--Fulfills Feature List Requirement: "Create an additional class which inhereits one or more properties from its parent"
    {
        //--Fulfills Feature List Requirement: "Create a dictionary or list, populate with several values, retrieve at least one value, and use it in your program"
        public static Dictionary<string, Guitar> guitars = new Dictionary<string, Guitar>()
        {
            { "Fender Jaguar", new Guitar() { Make = "Fender", Model = "Jaguar", Type = "solid-body electric guitar", Country = "Japan", Year = 1997, Serial = "A035931", Color = "White", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
            { "Fender Jazzmaster", new Guitar() { Make = "Fender", Model = "Jazzmaster", Type = "solid-body electric guitar", Country = "Japan", Year = 1997, Serial = "A019459", Color = "Sunburst", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
            { "Fender Mustang", new Guitar() { Make = "Fender", Model = "Mustang", Type = "solid-body electric guitar", Country = "USA", Year = 1966, Serial = "118054", Color = "Black", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
            { "Fender Japan Stratocaster", new Guitar() { Make = "Fender", Model = "Stratocaster", Type = "solid-body electric guitar", Country = "Japan", Year = 1993, Serial= "P038686", Color =  "Transparent Blue", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Light: 10-45", } },
            { "Fender USA Stratocaster", new Guitar() { Make = "Fender", Model = "Stratocaster", Type = "solid-body electric guitar", Country = "USA", Year = 2018, Serial = "US18004688", Color = "Black", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Super Light: 9-41"} },
            { "Gibson Les Paul", new Guitar() { Make = "Gibson", Model = "Les Paul Studio", Type = "solid-body electric guitar", Country = "USA", Year = 2011, Serial = "133310680", Color = "Walnut", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
            { "Gretsch 12-String", new Guitar() { Make = "Grestch", Model = "G5422-12 Electromatic 12-String", Type = "semi-hollow electric guitar", Country = "Korea", Year = 2012, Serial = "K512074003", Color = "Sunburst", StringBrand = "D'Addario", StringType = "Nickel Wound XL", StringGauge = "Light: 10-48", }  },
            { "Ibanez Artcore", new Guitar() { Make = "Ibanez", Model = "Artcore AS83", Type = "semi-hollow electric guitar", Country = "China", Year = 2005, Serial = "S05101444", Color = "Tobacco Burst", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium 11-48", } },
            { "Martin Auditorium", new Guitar() { Make = "Martin",Model = "00016-SGT Auditorium", Type = "hollow-body acoustic guitar", Country = "USA", Year = 2003, Serial = "921955", Color = "Natural Spruce", StringBrand = "D'Addario", StringType = "Phosphor Bronze", StringGauge ="Light: 12-53", } },
        };

        //--implements the IDictionaryMethods interface, prints each key in the Guitar dictionary
        public void InstrumentList()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, Guitar> pair in guitars)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }

        //--implements the IDictionaryMethods interface, provides the unique body for the PrintInstrument method
        public void PrintInstrument()
        {
            Console.WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            Console.WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. Its serial number is {Serial}.");
            Console.WriteLine($"It uses {InstrumentString} gauge strings.");
            Console.WriteLine();
        }

        //-implements the IDictionaryMethods interface, counts the number of guitars in the dictionary
        public void CountInstruments()
        {
            Console.WriteLine("You have " + guitars.Count + " guitars.");
            Console.WriteLine();
        }
        
        public void PrintGuitar()
        {
            // InstrumentText.PrintInstrument();
        }
    }
}
