using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments.Program;

namespace MyInstruments
{
    public class Ukulele : MusicalInstrument, IMusicalInstrument 
        //--Fulfills Feature List Requirement: "Create an additional class which inhereits one or more properties from its parent"
    {
        public string size { get; set; }

        //--Fulfills Feature List Requirement: "Create a dictionary or list, populate with several values, retrieve at least one value, and use it in your program"
        public static Dictionary<string, Ukulele> ukuleles = new Dictionary<string, Ukulele>
        {
            { "Cordoba Ukulele", new Ukulele() { make = "Cordoba", model = "20-TMCE", type = "hollow-body acoustic ukulele", country = "China", year = 2017, serial = "41638150", color = "Natural Mahogany", size = "tenor", stringBrand = "D'Addario", stringType = "Fluorocarbon", stringGauge = "Tenor: 20-22", } },
            { "Lanikai Ukulele", new Ukulele() { make = "Lanikai", model = "LU-11", type = "hollow-body acoustic ukulele", country = "China", year = 2012, serial = "Y31107", color = "Natural Nato", size = "soprano", stringBrand = "D'Addario", stringType = "Fluorocarbon", stringGauge = "Soprano: 20-22", } },
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
            Console.WriteLine($"It uses {instrumentString} gauge strings.");
            Console.WriteLine();
        }

        public void CountInstruments()
        {
            Console.WriteLine("You have " + ukuleles.Count + " guitars.");
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

