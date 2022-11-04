using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Console;

namespace MyInstruments
{
    public class KeyboardInstrument : MusicalInstrument
    {
        public string? NumberOfKeys { get; set; }
        public string? KeyWeight { get; set; }

        public static Dictionary<string, KeyboardInstrument> keyboards = new Dictionary<string, KeyboardInstrument>
        {
            { "Casio CDP-100", new KeyboardInstrument() { Make = "Casio", Model = "CDP-100", Type = "digital piano", Country = "China", Year = 2009,
                Serial = "6032098R", Color = "Black", NumberOfKeys = "88", KeyWeight = "weighted"} },
            { "Alesis Q25", new KeyboardInstrument() { Make = "Alesis", Model = "Q25", Type = "usb\\midi controller", Country = "Japan", Year = 2011,
                Serial = "BA100811470003", Color = "Black", NumberOfKeys = "25", KeyWeight = "non-weighted"} },
            { "Estey Pump Organ", new KeyboardInstrument() {Make = "Estey", Model = "Pump Organ", Type = "folding pump organ", Country = "USA", Year = 1930,
                Serial = "unknown", Color = "Natural Wood", NumberOfKeys = "49", KeyWeight = "weighted"} },
        };

        public void ListInstruments()
        {
            WriteLine();
            foreach (KeyValuePair<string, KeyboardInstrument> pair in keyboards)
                WriteLine(pair.Key);
            WriteLine();
        }

        public void PrintInstrument()
        {
            WriteLine($"Your {InstrumentName} is a {Type} that was made in {Country} in {Year}.");
            WriteLine($"It is {InstrumentAge} years old. It is {Color} in color. It has {NumberOfKeys} {KeyWeight} keys. Its serial number is {Serial}.");;
            WriteLine();
        }

        public void CountInstruments()
        {
            WriteLine("You have " + keyboards.Count + " keyboard instruments.");
            WriteLine();
        }
    }
}
