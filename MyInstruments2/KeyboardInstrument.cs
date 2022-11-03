using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MyInstruments
{
    public class KeyboardInstrument : MusicalInstrument
    {
        public string? NumberOfKeys { get; set; }
        public string? KeyWeight { get; set; }

        public static Dictionary<string, KeyboardInstrument> keyboards = new Dictionary<string, KeyboardInstrument>
        {
            { "Casio CDP-100", new KeyboardInstrument() { Make = "Casio", Model = "CDP-100", Type = "digital piano", Country = "China", Year = 2009,
                Serial = "6032098R", Color = "Black", NumberOfKeys = "88", KeyWeight = "Weighted"} },
        };

        public void ListInstruments()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, KeyboardInstrument> pair in keyboards)
                Console.WriteLine(pair.Key);
            Console.WriteLine();
        }

        public void PrintInstrument()
        {
            Console.WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            Console.WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It has {NumberOfKeys} {KeyWeight} keys. Its serial number is {Serial}.");;
            Console.WriteLine();
        }
    }
}
