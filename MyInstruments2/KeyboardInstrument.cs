using static System.Console;

namespace MyInstruments
{
    public class KeyboardInstrument : MusicalInstrument
    {
        private string? NumberOfKeys { get; set; }
        private string? KeyWeight { get; set; }

        public static readonly Dictionary<string, KeyboardInstrument> keyboardInstruments = new Dictionary<string, KeyboardInstrument>
        {
            { "casio cdp-100", new KeyboardInstrument() { Make = "Casio", Model = "CDP-100", Type = "digital piano", Country = "China", Year = 2009,
                Serial = "6032098R", Color = "Black", NumberOfKeys = "88", KeyWeight = "weighted"} },
            { "alesis q25", new KeyboardInstrument() { Make = "Alesis", Model = "Q25", Type = "usb\\midi controller", Country = "Japan", Year = 2011,
                Serial = "BA100811470003", Color = "Black", NumberOfKeys = "25", KeyWeight = "non-weighted"} },
            { "estey pump organ", new KeyboardInstrument() {Make = "Estey", Model = "Pump Organ", Type = "folding pump organ", Country = "USA", Year = 1930,
                Serial = "unknown", Color = "Natural Wood", NumberOfKeys = "49", KeyWeight = "weighted"} },
        };

        public void PrintInstrument()
        {
            WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It has {NumberOfKeys} {KeyWeight} keys. Its serial number is {Serial}.");;
        }
    }
}
