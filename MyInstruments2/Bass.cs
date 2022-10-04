using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class Bass : MusicalInstrument, IPrintInstrument //--Bass class inherits from MusicalInstrument for seperate organization of basses
    {
       public string scale { get; set; }

        //--this dictionary contains all basses available to the program
       public static Dictionary<string, Bass> basses = new Dictionary<string, Bass>()
       {
            { "Fender Dimension Bass", new Bass() { make = "Fender", model = "Dimension Bass", type = "solid-body electric bass", country = "USA", year = 2016, serial = "US16030876", color = "Black", scale = "long", stringBrand = "D'Addario", stringType = "Chrome Flat Wound Long Scale", stringGauge= "Custom Light: 40-100", } },
            { "Fender Mustang Bass", new Bass() { make = "Fender", model = "Justin Meldal-Johnsen Signature Mustang Bass", type = "solid-body electric bass", country = "Mexico", year = 2017, serial = "MX17972532", color = "Daphne Blue", scale = "short", stringBrand = "D'Addario", stringType = "Chrome Flatwound Medium Scale", stringGauge = "Light: 45-100" } },
            { "Fender Precision Bass",  new Bass() { make = "Fender", model = "Precision Bass", type = "solid-body electric bass", country = "Mexico", year = 2021, serial = "MX21254822", color = "Buttercream", scale = "long", stringBrand = "GHS", stringType = "Pressure Wound", stringGauge = "Medium: 44-106", } },
            { "Hofner Club Bass", new Bass() { make = "Hofner", model = "Club", type = "hollow-body electric bass", country = "China",  year = 2020, serial = "X0501H152", color = "Black", scale = "short", stringBrand = "La Bella", stringType = "Deep Talkin' Beatle Bass", stringGauge = "Light: 39-96", } },
       };
        //-- this method prints each key in the Bass dictionary
       public override void InstrumentList()
       {
            Console.WriteLine();
            foreach (KeyValuePair<string, Bass> pair in basses)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
       }
        public void PrintInstrument()
        {
            Console.WriteLine($"Your {instrumentName} is a {type} that was made in {country} in {year}.");
            Console.WriteLine($"It is {instrumentAge} years old. It is {color} in color. It is a {scale} scale bass. Its serial number is {serial}.");
            Console.WriteLine($"It uses {instrumentString} gauge strings.");
            Console.WriteLine();
        }
    }
}
