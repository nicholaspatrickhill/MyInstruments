using MyInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments.Program;

namespace MyInstruments
{
    public class Ukulele : MusicalInstrument, IDictionaryMethods 
        // Fulfills Feature List Requirement: "Create an additional class which inhereits one or more properties from its parent"
    {
        public string? Size { get; set; }

        // Fulfills Feature List Requirement: "Create a dictionary or list, populate with several values, retrieve at least one value, and use it in your program"
        public static Dictionary<string, Ukulele> ukuleles = new Dictionary<string, Ukulele>
        {
            { "Cordoba Ukulele", new Ukulele() { Make = "Cordoba", Model = "20-TMCE", Type = "hollow-body acoustic ukulele", Country = "China", Year = 2017,
                Serial = "41638150", Color = "Natural Mahogany", Size = "tenor", StringBrand = "D'Addario", StringType = "Fluorocarbon", StringGauge = "Tenor: 20-22", } },
            { "Lanikai Ukulele", new Ukulele() { Make = "Lanikai", Model = "LU-11", Type = "hollow-body acoustic ukulele", Country = "China", Year = 2012,
                Serial = "Y31107", Color = "Natural Nato", Size = "soprano", StringBrand = "D'Addario", StringType = "Fluorocarbon", StringGauge = "Soprano: 20-22", } },
        };

        public void ListInstruments()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, Ukulele> pair in ukuleles)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }

        public void PrintInstrument()
        {
            Console.WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            Console.WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It is a {Size} sized instrument. Its serial number is {Serial}.");
            Console.WriteLine($"It uses {InstrumentString} gauge strings.");
            Console.WriteLine();
        }

        public void CountInstruments()
        {
            Console.WriteLine("You have " + ukuleles.Count + " ukuleles.");
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

