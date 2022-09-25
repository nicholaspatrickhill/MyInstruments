using System.Xml.Schema;

namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
            Dictionary<string, MusicalInstrument> instruments = new Dictionary<string, MusicalInstrument>()
            {
                { "Fender Jazzmaster", new MusicalInstrument() { Make = "Fender", Model = "Jazzmaster", Type = "guitar", Country = "Japan", Year = 1997, Serial = "A019459", Color = "Sunburst", } },
                { "Fender Jaguar", new MusicalInstrument() { Make = "Fender", Model = "Jaguar", Type = "guitar", Country = "Japan", Year = 1997, Serial = "A035931", Color = "White" } },
                { "MIA Fender Stratocaster", new MusicalInstrument() { Make = "Fender", Model = "Stratocaster", Type ="guitar", Country = "USA", Year = 2018, Serial = "US18004688", Color = "Black", } },
                { "MIJ Fender Stratocaster", new MusicalInstrument() { Make = "Fender", Model = "Stratocaster", Type = "guitar", Country = "Japan", Year = 1993, Serial= "P038686", Color =  "Transparent Blue", } },
                { "Hofner Club Bass", new MusicalInstrument() { Make = "Hofner", Model = "Club", Type = "bass", Country = "China", Serial = "X0501H152", Color = "Black", } },
                { "Fender Precision Bass",  new MusicalInstrument() { Make = "Fender", Model = "Precision Bass", Type = "bass", Country = "Mexico", Year = 2021, Serial = "MX21254822", Color = "Buttercream", } },
            };

            while (true)
            {
                Console.WriteLine("Hello. Which instrument would you like to review? Type Quit to exit the program.");
                string input = Console.ReadLine();

                if (input == "Quit")
                {
                    break;
                }
                else if (instruments.ContainsKey(input))
                {
                    MusicalInstrument instrument = instruments[input];
                    Console.WriteLine($"Your {instrument.InstrumentName} is a {instrument.Type} that was made in {instrument.Country} in {instrument.Year}. ");
                    Console.WriteLine($"It is {instrument.Age} years old. It is {instrument.Color} in color. Its serial number is {instrument.Serial}.");
                    Console.WriteLine();
                }
                else if (input == "All")
                {
                    MakeList.InstrumentInventory();
                }
                else
                {
                    Console.WriteLine("That instrument is not in your collection.");
                }
            }
        }
    }
}