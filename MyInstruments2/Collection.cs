using Spectre.Console;
using System.Globalization;
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
        private static readonly string[] keyboardKeysArray = keyboards.Keys.ToArray();

        public static void PrintGuitarKeysArray()
        {
            Array.Sort(guitarKeysArray);
            
            foreach (string guitar in guitarKeysArray)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(guitar);
                }
        }

        public static void PrintBassKeysArray()
        {
            Array.Sort(bassKeysArray);

            foreach (string bass in bassKeysArray)
            {
                ForegroundColor = ConsoleColor.Blue;
                WriteLine(bass);
            }
        }

        public static void PrintOtherStringInstrumentKeysArray()
        {
            Array.Sort(otherStringInstrumentKeysArray);

            foreach (string other in otherStringInstrumentKeysArray)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine(other);            
            }
        }

        public static void PrintKeyboardKeysArray()
        {
            Array.Sort(keyboardKeysArray);

            foreach (string keyboard in keyboardKeysArray)
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
                PrintKeyboardKeysArray();
            }
        }

        public static void ListAllInstruments()
        {
            ConsoleMessage.PrintAppHeader();
            WriteLine();
            PrintGuitarKeysArray();
            WriteLine();
            PrintBassKeysArray();
            WriteLine();
            PrintOtherStringInstrumentKeysArray();
            WriteLine();
            PrintKeyboardKeysArray();
        }

        public static void SearchForFenderInstruments()
        {
            var allInstrumentsArray = guitarKeysArray.Concat(bassKeysArray).Concat(otherStringInstrumentKeysArray).Concat(keyboardKeysArray).ToArray();

            var search = allInstrumentsArray.Where(p => p.Contains("fender"));
            foreach (var result in search)
            {
                WriteLine("{0}", result);
            }
        }

        public static void SaveInstrumentsToTextFile()
        {
            {
                string myInstruments = @"C:\temp\MyInstruments.txt";
                myInstruments = Path.GetFullPath(myInstruments);
                Directory.CreateDirectory(Path.GetDirectoryName(myInstruments));

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

                    file.WriteLine("KEYBOARDS");
                    foreach (string keyboard in keyboardKeysArray)
                    {
                        Array.Sort(keyboardKeysArray);
                        file.WriteLine(keyboard.ToUpper());
                    }

                    file.Close();

                    ForegroundColor = ConsoleColor.White;
                    ConsoleMessage.PrintAppHeader();
                    WriteLine();
                    WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
                }
            }
        }

        public static void CountAllInstruments()
        {
            int guitarsCount = Guitar.guitars.Count;
            int bassesCount = Bass.basses.Count;
            int otherCount = otherStringInstruments.Count;
            int keyboardsCount = KeyboardInstrument.keyboards.Count;
            int totalCount = guitarsCount + bassesCount + otherCount + keyboardsCount;

            ForegroundColor = ConsoleColor.White;
            ConsoleMessage.PrintAppHeader();
            WriteLine();
            WriteLine();

            AnsiConsole.Write(new BreakdownChart()
                .Width(65)
                .AddItem("Guitars", guitarsCount, Color.Red)
                .AddItem("Basses", bassesCount, Color.Blue)
                .AddItem("Other String Instruments", otherCount, Color.Green)
                .AddItem("Keyboard Instruments", keyboardsCount, Color.Yellow));

            WriteLine();
            WriteLine("You have " + totalCount + " total instruments in your collection.");
        }
    }
}


