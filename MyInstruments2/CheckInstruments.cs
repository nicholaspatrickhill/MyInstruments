using System.Diagnostics.Metrics;
using System.Xml.Schema;

namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
            // this dictionary contains all guitars available to the program
            Dictionary<string, Guitar> guitars = new Dictionary<string, Guitar>()
            {
                { "Fender Jaguar", new Guitar() { Make = "Fender", Model = "Jaguar", Type = "solid-body electric guitar", Country = "Japan", Year = 1997, Serial = "A035931", Color = "White", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
                { "Fender Jazzmaster", new Guitar() { Make = "Fender", Model = "Jazzmaster", Type = "solid-body electric guitar", Country = "Japan", Year = 1997, Serial = "A019459", Color = "Sunburst", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
                { "Fender Mustang", new Guitar() { Make = "Fender", Model = "Mustang", Type = "solid-body electric guitar", Country = "USA", Year = 1966, Serial = "118054", Color = "Black", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
                { "MIA Fender Stratocaster", new Guitar() { Make = "Fender", Model = "Stratocaster", Type = "solid-body electric guitar", Country = "USA", Year = 2018, Serial = "US18004688", Color = "Black", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Super Light: 9-41"} },
                { "MIJ Fender Stratocaster", new Guitar() { Make = "Fender", Model = "Stratocaster", Type = "solid-body electric guitar", Country = "Japan", Year = 1993, Serial= "P038686", Color =  "Transparent Blue", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Light: 10-45", } },
                { "Gibson Les Paul", new Guitar() { Make = "Gibson", Model = "Les Paul Studio", Type = "solid-body electric guitar", Country = "USA", Year = 2011, Serial = "133310680", Color = "Walnut", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium: 11-48", } },
                { "Gretsch 12-String", new Guitar() { Make = "Grestch", Model = "G5422-12 Electromatic 12-String", Type = "semi-hollow electric guitar", Country = "Korea", Year = 2012, Serial = "K512074003", Color = "Sunburst", StringBrand = "D'Addario", StringType = "Nickel Wound XL", StringGauge = "Light: 10-48", }  },
                { "Ibanez Artcore", new Guitar() { Make = "Ibanez", Model = "Artcore AS83", Type = "semi-hollow electric guitar", Country = "China", Year = 2005, Serial = "S05101444", Color = "Tobacco Burst", StringBrand = "D'Addario", StringType = "Pure Nickel XL", StringGauge = "Medium 11-48", } },
                { "Martin Auditorium", new Guitar() { Make = "Martin", Model = "00016-SGT Auditorium", Type = "hollow-body acoustic guitar", Country = "USA", Year = 2003, Serial = "921955", Color = "Natural", StringBrand = "D'Addario", StringType = "Phosphor Bronze", StringGauge ="Light: 12-53", } },
            };
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
                    Console.WriteLine($"Your {bass.InstrumentName}" ); Console.WriteLine($"Your {bass.InstrumentName} is a {bass.Type} that was made in {bass.Country} in {bass.Year}.");
                    Console.WriteLine($"It is {bass.InstrumentAge} years old. It is {bass.Color} in color. It is a {bass.Scale} scale bass. Its serial number is {bass.Serial}.");
                    Console.WriteLine($"It uses {bass.InstrumentString} gauge strings.");
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