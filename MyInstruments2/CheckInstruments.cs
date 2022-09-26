using System.Xml.Schema;

namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
            // dictionary contains all instruments available to the program
            Dictionary<string, MusicalInstrument> instruments = new Dictionary<string, MusicalInstrument>()
            {
                { "Fender Jaguar", new MusicalInstrument() { Make = "Fender", Model = "Jaguar", Type = "solid-body electric guitar", Country = "Japan", Year = 1997, Serial = "A035931", Color = "White", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Medium: 11-48", } },
                { "Fender Jazzmaster", new MusicalInstrument() { Make = "Fender", Model = "Jazzmaster", Type = "solid-body electric guitar", Country = "Japan", Year = 1997, Serial = "A019459", Color = "Sunburst", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Medium: 11-48", } },
                { "Fender Mustang", new MusicalInstrument() { Make = "Fender", Model = "Mustang", Type = "solid-body electric guitar", Country = "USA", Year = 1966, Serial = "118054", Color = "Black", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Medium: 11-48", } },
                { "MIA Fender Stratocaster", new MusicalInstrument() { Make = "Fender", Model = "Stratocaster", Type = "solid-body electric guitar", Country = "USA", Year = 2018, Serial = "US18004688", Color = "Black", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Super Light: 9-41"} },
                { "MIJ Fender Stratocaster", new MusicalInstrument() { Make = "Fender", Model = "Stratocaster", Type = "solid-body electric guitar", Country = "Japan", Year = 1993, Serial= "P038686", Color =  "Transparent Blue", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Light: 10-45", } },
                { "Gibson Les Paul", new MusicalInstrument() { Make = "Gibson", Model = "Les Paul Studio", Type = "solid-body electric guitar", Country = "USA", Year = 2011, Serial = "133310680", Color = "Walnut", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Medium: 11-48", } },
                { "Grestch 12-String", new MusicalInstrument() { Make = "Grestch", Model = "G5422-12 Electromatic 12-String", Type = "semi-hollow electric guitar", Country = "Korea", Year = 2012, Serial = "K512074003", Color = "Sunburst", StringBrand = "D'Addario", StringType = "Nickel Wound", StringGauge = "Light: 10-48", }  },
                { "Ibanez Artcore", new MusicalInstrument() { Make = "Ibanez", Model = "Artcore AS83", Type = "semi-hollow electric guitar", Country = "China", Year = 2005, Serial = "S05101444", Color = "Tobacco Burst", StringBrand = "D'Addario", StringType = "Pure Nickel", StringGauge = "Medium 11-48", } },
                { "Martin Auditorium", new MusicalInstrument() { Make = "Martin", Model = "00016-SGT Auditorium", Type = "hollow-body acoustic guitar", Country = "USA", Year = 2003, Serial = "921955", Color = "Natural", StringBrand = "D'Addario", StringType = "Phosphor Bronze", StringGauge ="Light: 12-53", } },
                { "Fender Dimension Bass", new MusicalInstrument() { Make = "Fender", Model = "Dimension Bass", Type = "solid-body electric bass", Country = "USA", Year = 2016, Serial = "US16030876", Color = "Black", StringBrand = "D'Addario", StringType = "Chrome", StringGauge= " Custom Light: 40-100", } },
                { "Fender Mustang Bass", new MusicalInstrument() },
                { "Fender Precision Bass",  new MusicalInstrument() { Make = "Fender", Model = "Precision Bass", Type = "solid-body electric bass", Country = "Mexico", Year = 2021, Serial = "MX21254822", Color = "Buttercream", StringBrand = "GHS", StringType = "Pressure Wound Medium", StringGauge = "Medium: 44-106", } },
                { "Hofner Club Bass", new MusicalInstrument() { Make = "Hofner", Model = "Club", Type = "hollow-body electric bass", Country = "China",  Year = 2020, Serial = "X0501H152", Color = "Black", StringBrand = "La Bella", StringType = "Deep Talkin' Beatle Bass", StringGauge = "Light: 39-96", } },
            };

            // setting console size
            Console.SetWindowSize(138, 40);

            // header code to start the program
            Console.WriteLine("........................");
            Console.WriteLine("... MyInstruments2.0 ...");
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
                else if (instruments.ContainsKey(input))
                {
                    MusicalInstrument instrument = instruments[input];
                    Console.WriteLine($"Your {instrument.InstrumentName} is a {instrument.Type} that was made in {instrument.Country} in {instrument.Year}. ");
                    Console.WriteLine($"It is {instrument.InstrumentAge} years old. It is {instrument.Color} in color. Its serial number is {instrument.Serial}.");
                    Console.WriteLine($"It uses {instrument.InstrumentString} gauge strings.");
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
                    Console.WriteLine("... MyInstruments2.0 ...");
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