using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyInstruments
{
    public class Bass : StringInstrument, IMusicalInstrument 
    {
        private string? Scale { get; set; }

        public static Dictionary<string, Bass> basses = new Dictionary<string, Bass>()
        {
            { "Fender Dimension Bass", new Bass() { Make = "Fender", Model = "Dimension Bass", Type = "solid-body electric bass", Country = "USA", Year = 2016, 
                Serial = "US16030876", Color = "Black", Scale = "long", StringBrand = "D'Addario", StringType = "Chrome Flat Wound Long Scale", StringGauge= "Custom Light: 40-100", } },
            { "Fender Mustang Bass", new Bass() { Make = "Fender", Model = "Justin Meldal-Johnsen Signature Mustang Bass", Type = "solid-body electric bass", Country = "Mexico", Year = 2017, 
                Serial = "MX17972532", Color = "Daphne Blue", Scale = "short", StringBrand = "D'Addario", StringType = "Chrome Flatwound Medium Scale", StringGauge = "Light: 45-100" } },
            { "Fender Precision Bass",  new Bass() { Make = "Fender", Model = "Precision Bass", Type = "solid-body electric bass", Country = "Mexico", Year = 2021, 
                Serial = "MX21254822", Color = "Buttercream", Scale = "long", StringBrand = "GHS", StringType = "Pressure Wound", StringGauge = "Medium: 44-106", } },
            { "Hofner Club Bass", new Bass() { Make = "Hofner", Model = "Club", Type = "hollow-body electric bass", Country = "China",  Year = 2020, 
                Serial = "X0501H152", Color = "Black", Scale = "short", StringBrand = "La Bella", StringType = "Deep Talkin' Beatle Bass", StringGauge = "Light: 39-96", } },
        };

        public void ListInstruments()
        {
            WriteLine();
            foreach (KeyValuePair<string, Bass> pair in basses)
                WriteLine(pair.Key);
            WriteLine();
        }

        public void PrintInstrument()
        {
            WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It is a {Scale} scale bass. Its serial number is {Serial}.");
            WriteLine($"It uses {InstrumentString} gauge strings.");
            WriteLine();
        }

        public void CountInstruments()
        {
            WriteLine("You have " + basses.Count + " basses.");
            WriteLine();
        }
    }
}
