using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.UserSelection;
using static System.Console;
using Spectre.Console;
using Spectre.Console.Rendering;

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
            ConsoleWindow.PrintReviewInstrumentsHeader();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;

                WriteLine();
                WriteLine("Which instrument would you like to review?");

                var guitar = new Guitar();
                var bass = new Bass();
                var otherStringInstrument = new OtherStringInstrument();
                var keyboard = new KeyboardInstrument();

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
            if (input == "Guitars")
            {
                guitarsKeyList.ForEach(WriteLine);
            }
            else if (input == "Basses")
            {
                bassesKeyList.ForEach(WriteLine);
            }
            else if (input == "Other")
            {
                otherStringInstrumentsKeyList.ForEach(WriteLine);
            }
            else if (input == "Keyboards")
            {
                keyboardInstrumentsKeyList.ForEach(WriteLine);
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
            WriteLine("YOUR INSTRUMENTS:");
            WriteLine();
            WriteLine("GUITARS:");
            guitarsKeyList.ForEach(WriteLine);
            WriteLine();
            WriteLine("BASSES:");
            bassesKeyList.ForEach(WriteLine);
            WriteLine();
            WriteLine("OTHER STRING INSTRUMENTS:");
            otherStringInstrumentsKeyList.ForEach(WriteLine);
            WriteLine();
            WriteLine("KEYBOARDS:");
            keyboardInstrumentsKeyList.ForEach(WriteLine);
        }

        public static void ListAllInstrumentsInTable()
        {
            ForegroundColor = ConsoleColor.White;
            ConsoleWindow.PrintAppHeader();
            WriteLine();

            var table = new Table();

            table.AddColumn("Guitars:");
            table.AddColumn("Basses:");
            table.AddColumn("Other String Instruments:");
            table.AddColumn("Keyboards:");

            

            foreach (var item in guitarsKeyList)
                table.AddRow(item);

            foreach (var item2 in bassesKeyList)
                table.AddRow(item2);

            foreach (var item3 in otherStringInstrumentsKeyList)
                table.AddRow(item3);

            foreach (var item4 in keyboardInstrumentsKeyList)
                table.AddRow(item4);         

            AnsiConsole.Write(table);
        }
    }
}


