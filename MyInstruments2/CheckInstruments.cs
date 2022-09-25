namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
            Dictionary<string, MusicalInstrument> instruments = new Dictionary<string, MusicalInstrument>()
            {
                { "Jazzmaster", new MusicalInstrument() { Make = "Fender", Model = "Jazzmaster", Type = "guitar", Country = "Japan", Year = 1997, Serial = "A019459", Color = "Sunburst", } },
                { "Jaguar", new MusicalInstrument() { Make = "Fender", Model = "Jaguar", Type = "guitar", Country = "Japan", Year = 1997, Serial = "A035931", Color = "White" } },
                /// MusicalInstrument StratUSA = new MusicalInstrument("Fender", "Stratocaster", "guitar", "USA", 2018, DateTime.Now.Year - 2018, "US18004688", "Black");
                /// MusicalInstrument StratJapan = new MusicalInstrument("Fender", "Stratocaster", "guitar", "Japan", 1993, DateTime.Now.Year - 1993, "P038686", "Transparent Blue");
                /// MusicalInstrument Hofner = new MusicalInstrument("Hofner", "Club", "bass", "China", 0, 0, "X0501H152", "Black");
                /// MusicalInstrument PrecisionBass = new MusicalInstrument("Fender", "Precision Bass", "bass", "Mexico", 2021, DateTime.Now.Year - 2021, "MX21254822", "Buttercream");
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