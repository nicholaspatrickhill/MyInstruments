using Spectre.Console;
using System.Globalization;
using static MyInstruments.Bass;
using static MyInstruments.Guitar;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.UserSelection;
using static System.Console;

namespace MyInstruments
{
    class Collection
    {
        public static List<string> guitarsKeyList = new List<string>(guitars.Keys);
        public static List<string> bassesKeyList = new List<string>(basses.Keys);
        public static List<string> otherStringInstrumentsKeyList = new List<string>(otherStringInstruments.Keys);
        public static List<string> keyboardInstrumentsKeyList = new List<string>(keyboards.Keys);

        public static void ReviewAnyInstrument()
        {
            ConsoleMessage.PrintAppHeader();

            var repeat = true;
            while (repeat)
            {
                
                ConsoleMessage.PrintReviewAnyInstrumentHeader();

                var guitar = new Guitar();
                var bass = new Bass();
                var otherStringInstrument = new OtherStringInstrument();
                var keyboard = new KeyboardInstrument();

                WriteLine();
                string? input = UserInput();

                repeat = SelectInstrument(repeat, input);

                static string? UserInput()
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    string? input = ReadLine().ToLower();
                    return input;
                }
            }
        }

        public static void CountAllInstruments()
        {
            int num1 = guitars.Count;
            int num2 = basses.Count;
            int num3 = otherStringInstruments.Count;
            int num4 = keyboards.Count;
            int num5 = num1 + num2 + num3 + num4;

            ForegroundColor = ConsoleColor.White;
            ConsoleMessage.PrintAppHeader();
            WriteLine();
            WriteLine();

            AnsiConsole.Write(new BreakdownChart()
                .Width(65)
                .AddItem("Guitars", num1, Color.Red)
                .AddItem("Basses", num2, Color.Blue)
                .AddItem("Other String Instruments", num3, Color.Green)
                .AddItem("Keyboard Instruments", num4, Color.Yellow));

            WriteLine();
            WriteLine("You have " + num5 + " total instruments in your collection.");
        }

        public static void ListInstrumentsByType(string input)
        {
       if (input == "guitars")
            {
                ConsoleMessage.PrintGuitarsKeyList();
            }
            else if (input == "basses")
            {
                ConsoleMessage.PrintBassesKeyList();
            }
            else if (input == "other")
            {
                ConsoleMessage.PrintOtherStringInstrumentsKeyList();
            }
            else if (input == "keyboards")
            {
                ConsoleMessage.PrintKeyboardInstrumentsKeyList();
            }
        }

        public static void SaveInstrumentsToTextFile()
        {
            string myInstruments = @"C:\temp\MyInstruments.txt";
            myInstruments = Path.GetFullPath(myInstruments);
            Directory.CreateDirectory(Path.GetDirectoryName(myInstruments));

            using StreamWriter file = new StreamWriter(myInstruments);
            {
                file.WriteLine("MY INSTRUMENTS");
                file.WriteLine();

                file.WriteLine("GUITARS:");
                guitarsKeyList.ForEach(file.WriteLine);
                file.WriteLine();

                file.WriteLine("BASSES:");
                bassesKeyList.ForEach(file.WriteLine);
                file.WriteLine();

                file.WriteLine("OTHER STRING INSTRUMENTS:");
                otherStringInstrumentsKeyList.ForEach(file.WriteLine);
                file.WriteLine();

                file.WriteLine("KEYBOARDS:");
                keyboardInstrumentsKeyList.ForEach(file.WriteLine);
            }
            file.Close();

            ForegroundColor = ConsoleColor.White;
            ConsoleMessage.PrintAppHeader();
            WriteLine();
            WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
        }

        public static void ListAllInstruments()
        {
            ForegroundColor = ConsoleColor.White;
            ConsoleMessage.PrintAppHeader();
            WriteLine();

            ConsoleMessage.PrintGuitarsKeyList();
            WriteLine();

            ConsoleMessage.PrintBassesKeyList();
            WriteLine();

            ConsoleMessage.PrintOtherStringInstrumentsKeyList();
            WriteLine();

            ConsoleMessage.PrintKeyboardInstrumentsKeyList();
        }
    }
}


