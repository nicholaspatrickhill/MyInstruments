using MyInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments.Program;

namespace MyInstruments
{
    public class OtherStringInstrument : StringInstrument, IMusicalInstrument
    // Fulfills Feature List Requirement: "Create an additional class which inhereits one or more properties from its parent"
    {
        public string? Size { get; set; }

        // Fulfills Feature List Requirement: "Create a dictionary or list, populate with several values, retrieve at least one value, and use it in your program"
        public static Dictionary<string, OtherStringInstrument> otherStringInstruments = new Dictionary<string, OtherStringInstrument>
        {
            { "Cordoba Ukulele", new OtherStringInstrument() { Make = "Cordoba", Model = "20-TMCE", Type = "hollow-body acoustic ukulele", Country = "China", Year = 2017,
                Serial = "41638150", Color = "Natural Mahogany", Size = "tenor", StringBrand = "D'Addario", StringType = "Fluorocarbon", StringGauge = "Tenor: 20-22", } },
            { "Lanikai Ukulele", new OtherStringInstrument() { Make = "Lanikai", Model = "LU-11", Type = "hollow-body acoustic ukulele", Country = "China", Year = 2012,
                Serial = "Y31107", Color = "Natural Nato", Size = "soprano", StringBrand = "D'Addario", StringType = "Fluorocarbon", StringGauge = "Soprano: 20-22", } },
            { "Vega Banjo", new OtherStringInstrument() { Make = "Vega", Model = "SS-5 Folklore", Type =  "open-back acoustic banjo", Country = "USA", Year = 1963,
                Serial = "A-12107", Color = "Natural Maple", Size = "long neck", StringBrand = "John Pearse", StringType = "Nickel Wound X-Long", StringGauge = "Medium: 10-23", } },
            { "Rogue Lap Steel", new OtherStringInstrument() { Make = "Rogue", Model = "EA-3", Type = "electric lap steel guitar", Country = "Korea", Year = 2011,
                Serial = "unknown", Color = "Black",  Size = "short-scale", StringBrand = "Asher", StringType = "Electro Hawaiian EH6-15 Nickel-Wound", StringGauge = "Medium: 15-58"} },
        };

    public void ListInstruments()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, OtherStringInstrument> pair in otherStringInstruments)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }

        public void PrintInstrument()
        {
            Console.WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            Console.WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It is a {Size} instrument. Its serial number is {Serial}.");
            Console.WriteLine($"It uses {InstrumentString} gauge strings.");
            Console.WriteLine();
        }

        public void CountInstruments()
        {
            Console.WriteLine("You have " + otherStringInstruments.Count + " ukuleles.");
            Console.WriteLine();
        }
    }
}

