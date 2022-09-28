using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments2.Ukulele;
using static MyInstruments2.Guitar;

namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
           
            // this dictionary contains all basses available to the program
            Dictionary<string, Bass> basses = new Dictionary<string, Bass>()
            { 
                { "Fender Dimension Bass", new Bass() { Make = "Fender", Model = "Dimension Bass", Type = "solid-body electric bass", Country = "USA", Year = 2016, Serial = "US16030876", Color = "Black", Scale = "long", StringBrand = "D'Addario", StringType = "Chrome Flat Wound Long Scale", StringGauge= "Custom Light: 40-100", } },
                { "Fender Mustang Bass", new Bass() { Make = "Fender", Model = "Justin Meldal-Johnsen Signature Mustang Bass", Type = "solid-body electric bass", Country = "Mexico", Year = 2017, Serial = "MX17972532", Color = "Daphne Blue", Scale = "short", StringBrand = "D'Addario", StringType = "Chrome Flatwound Medium Scale", StringGauge = "Light: 45-100" } },
                { "Fender Precision Bass",  new Bass() { Make = "Fender", Model = "Precision Bass", Type = "solid-body electric bass", Country = "Mexico", Year = 2021, Serial = "MX21254822", Color = "Buttercream", Scale = "long", StringBrand = "GHS", StringType = "Pressure Wound", StringGauge = "Medium: 44-106", } },
                { "Hofner Club Bass", new Bass() { Make = "Hofner", Model = "Club", Type = "hollow-body electric bass", Country = "China",  Year = 2020, Serial = "X0501H152", Color = "Black", Scale = "short", StringBrand = "La Bella", StringType = "Deep Talkin' Beatle Bass", StringGauge = "Light: 39-96", } },
            };

            // setting console size
            Console.SetWindowSize(138, 40);

            // header code to start the program
            Console.WriteLine("........................");
            Console.WriteLine("...  MyInstruments2  ...");
            Console.WriteLine("........................");
            Console.WriteLine();
            Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
            Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Quit\" to exit the program. Type \"Clear\" to clear the console and start over.");
            Console.WriteLine();

            // loops through possible user inputs 
            while (true)
            {
                Console.WriteLine("Hello. Which instrument would you like to review?");
                string input = Console.ReadLine();

                if (input == "Quit")
                {
                    break;
                }
                else if (guitars.ContainsKey(input))
                {
                    Guitar guitar = guitars[input];
                    Console.WriteLine($"Your {guitar.InstrumentName} is a {guitar.Type} that was made in {guitar.Country} in {guitar.Year}.");
                    Console.WriteLine($"It is {guitar.InstrumentAge} years old. It is {guitar.Color} in color. Its serial number is {guitar.Serial}.");
                    Console.WriteLine($"It uses {guitar.InstrumentString} gauge strings.");
                    Console.WriteLine();
                }
                else if (basses.ContainsKey(input))
                { 
                    Bass bass = basses[input];
                    Console.WriteLine($"Your {bass.InstrumentName} is a {bass.Type} that was made in {bass.Country} in {bass.Year}.");
                    Console.WriteLine($"It is {bass.InstrumentAge} years old. It is {bass.Color} in color. It is a {bass.Scale} scale bass. Its serial number is {bass.Serial}.");
                    Console.WriteLine($"It uses {bass.InstrumentString} gauge strings.");
                    Console.WriteLine();
                }
               else if (ukuleles.ContainsKey(input))
                {
                    Ukulele ukulele = ukuleles[input];
                    Console.WriteLine($"Your {ukulele.InstrumentName} is a {ukulele.Type} that was made in {ukulele.Country} in {ukulele.Year}.");
                    Console.WriteLine($"It is {ukulele.InstrumentAge} years old. It is {ukulele.Color} in color. It is a {ukulele.Size} sized instrument. Its serial number is {ukulele.Serial}.");
                    Console.WriteLine();
                }
                else if (input == "All")
                {
                    MakeList.InstrumentInventory();
                    Console.WriteLine();
                }
                else if (input == "Clear")
                {
                    Console.Clear();
                    Console.WriteLine("........................");
                    Console.WriteLine("...  MyInstruments2  ...");
                    Console.WriteLine("........................");
                    Console.WriteLine();
                    Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
                    Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Quit\" to exit the program. Type \"Clear\" to clear the console and start over.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("That instrument is not in your collection. Please type \"All\" to see a list of all of your instruments.");
                    Console.WriteLine();
                }
            }
        }
    }
}