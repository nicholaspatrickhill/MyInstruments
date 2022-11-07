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
using static System.Console;

namespace MyInstruments
{
    public class OtherStringInstrument : StringInstrument, IMusicalInstrument
    {
        public string? Size { get; set; }

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

    //public void ListInstruments()
    //    {
    //        WriteLine();
    //        foreach (KeyValuePair<string, OtherStringInstrument> pair in otherStringInstruments)
    //            WriteLine(pair.Key);
    //        WriteLine();
    //    }

        public void PrintInstrument()
        {
            WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It is a {Size} instrument. Its serial number is {Serial}.");
            WriteLine($"It uses {InstrumentString} gauge strings.");
            WriteLine();
        }

        //public void CountInstruments()
        //{
        //    WriteLine("You have " + otherStringInstruments.Count + " ukuleles.");
        //    WriteLine();
        //}
    }
}

