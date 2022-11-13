using static MyInstruments.Bass;
using static MyInstruments.Guitar;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.OtherStringInstrument;
using static System.Console;

namespace MyInstruments
{
    class Collection
    {
        private static readonly string[] guitarKeysArray = guitars.Keys.ToArray();
        private static readonly string[] bassKeysArray = basses.Keys.ToArray();
        private static readonly string[] otherStringInstrumentKeysArray = otherStringInstruments.Keys.ToArray();
        private static readonly string[] keyboardInstrumentKeysArray = keyboardInstruments.Keys.ToArray();

        private static void PrintGuitarKeysArray()
        {
            Array.Sort(guitarKeysArray);
            
            foreach (string guitar in guitarKeysArray)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(guitar);
                }
        }

        private static void PrintBassKeysArray()
        {
            Array.Sort(bassKeysArray);

            foreach (string bass in bassKeysArray)
            {
                ForegroundColor = ConsoleColor.Blue;
                WriteLine(bass);
            }
        }

        private static void PrintOtherStringInstrumentKeysArray()
        {
            Array.Sort(otherStringInstrumentKeysArray);

            foreach (string other in otherStringInstrumentKeysArray)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine(other);            
            }
        }

        private static void PrintKeyboardInstrumentKeysArray()
        {
            Array.Sort(keyboardInstrumentKeysArray);

            foreach (string keyboard in keyboardInstrumentKeysArray)
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine(keyboard);
            }
        }

        public static void ListInstrumentsByType(string input)
        {
            if (input == "guitars")
            {
                PrintGuitarKeysArray();
            }
            else if (input == "basses")
            {
                PrintBassKeysArray();
            }
            else if (input == "other")
            {
                PrintOtherStringInstrumentKeysArray();
            }
            else if (input == "keyboards")
            {
                PrintKeyboardInstrumentKeysArray();
            }
        }

        public static void ListAllInstruments()
        {
            ConsoleMessages.PrintAppHeader();
            WriteLine();
            PrintGuitarKeysArray();
            WriteLine();
            PrintBassKeysArray();
            WriteLine();
            PrintOtherStringInstrumentKeysArray();
            WriteLine();
            PrintKeyboardInstrumentKeysArray();
        }

        public static void SearchForFenderInstruments()
        {
            var allInstrumentsArray = guitarKeysArray.Concat(bassKeysArray).Concat(otherStringInstrumentKeysArray).Concat(keyboardInstrumentKeysArray).ToArray();

            var search = allInstrumentsArray.Where(p => p.Contains("fender"));
            foreach (var result in search)
            {
                WriteLine("{0}", result);
            }
        }

        public static void SaveInstrumentsToTextFile()
        {
            ForegroundColor = ConsoleColor.White;
            ConsoleMessages.PrintAppHeader();
            WriteLine();
            WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");

            string myInstruments = @"C:\temp\MyInstruments.txt";
            using StreamWriter file = new StreamWriter(myInstruments);
            {
                file.WriteLine("MY INSTRUMENTS");
                file.WriteLine();
                file.WriteLine("GUITARS:");
                foreach (string guitar in guitarKeysArray)
                {
                    Array.Sort(guitarKeysArray);
                    file.WriteLine(guitar.ToUpper());
                }
                file.WriteLine();
                file.WriteLine("BASSES:");
                foreach (string bass in bassKeysArray)
                {
                    Array.Sort(bassKeysArray);
                    file.WriteLine(bass.ToUpper());
                }
                file.WriteLine();
                file.WriteLine("OTHER STRING INSTRUMENTS:");
                foreach (string other in otherStringInstrumentKeysArray)
                {
                    Array.Sort(otherStringInstrumentKeysArray);
                    file.WriteLine(other.ToUpper());
                }
                file.WriteLine();
                file.WriteLine("KEYBOARDS:");
                foreach (string keyboard in keyboardInstrumentKeysArray)
                {
                    Array.Sort(keyboardInstrumentKeysArray);
                    file.WriteLine(keyboard.ToUpper());
                }
                file.Close();
            } 
        }
    }
}


