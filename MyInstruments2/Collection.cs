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
            ConsoleWindow.PrintAppHeader();
            //ConsoleWindow.PrintReviewInstrumentsHeader();

            var repeat = true;
            while (repeat)
            {
                
                ConsoleWindow.PrintReviewAnyInstrumentHeader();

                //WriteLine();
                //WriteLine("Which instrument would you like to review?");
                //WriteLine("Type the key of the instrument that you wish to review and press enter. Type \"help\" for a list of other commands.");
                //WriteLine("What would you like to review?");


                var guitar = new Guitar();
                var bass = new Bass();
                var otherStringInstrument = new OtherStringInstrument();
                var keyboard = new KeyboardInstrument();

                WriteLine();
                string? input = UserInput();

                repeat = SelectInstrument(repeat, guitar, bass, otherStringInstrument, keyboard, input);

                static string? UserInput()
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    string? input = ReadLine();
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
            ConsoleWindow.PrintAppHeader();
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
                ConsoleWindow.PrintGuitarsKeyList();
            }
            else if (input == "basses")
            {
                ConsoleWindow.PrintBassesKeyList();
            }
            else if (input == "other")
            {
                ConsoleWindow.PrintOtherStringInstrumentsKeyList();
            }
            else if (input == "keyboards")
            {
                ConsoleWindow.PrintKeyboardInstrumentsKeyList();
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
            ConsoleWindow.PrintAppHeader();
            WriteLine();
            WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
        }

        public static void ListAllInstruments()
        {
            ForegroundColor = ConsoleColor.White;
            ConsoleWindow.PrintAppHeader();
            WriteLine();

            ConsoleWindow.PrintGuitarsKeyList();
            WriteLine();

            ConsoleWindow.PrintBassesKeyList();
            WriteLine();

            ConsoleWindow.PrintOtherStringInstrumentsKeyList();
            WriteLine();

            ConsoleWindow.PrintKeyboardInstrumentsKeyList();

            ForegroundColor = ConsoleColor.White;
        }
    }
}


