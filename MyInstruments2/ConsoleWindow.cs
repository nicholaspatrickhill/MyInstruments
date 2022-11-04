using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Program;
using static System.Console;

namespace MyInstruments
{
    class ConsoleWindow
    {
        public static void PrintHeader()
        {
            ForegroundColor = ConsoleColor.White;

            WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "............................."));
            WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", ".....   MyInstruments   ....."));
            WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "............................."));
            WriteLine();
            WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
            WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Commands\" to view a list of other commands.");
            WriteLine("Type \"Quit\" to exit the program.");
            WriteLine();
        }

        public static void ClearConsole()
        {
            Clear();
            //ConsoleWindow.PrintHeader();
        }

        public static void PrintErrorMessage()
        {
            WriteLine("Invalid Command. Please type \"Commands\" to see a list of available commands or try again.");
            WriteLine();
        }

        public static void PrintCommands()
        {
            WriteLine();
            WriteLine("Type...");
            WriteLine("\"Quit\" to exit the program.");
            WriteLine("\"Clear\" to clear the console.");
            WriteLine("\"All\" to see a list of all of your instruments.");
            WriteLine("\"Guitars\" to see a list of all of your guitars.");
            WriteLine("\"Basses\" to see a list of all of your basses.");
            WriteLine("\"Other String Instruments\" to see a list of all of your ukuleles.");
            WriteLine("\"Keyboards\" to see a list of all of your keyboard instruments");
            WriteLine("\"Count All\" to see the total quantity of instruments in your collection.");
            WriteLine("\"Count Guitars\" to see the quantity of guitars in your collection.");
            WriteLine("\"Count Basses\" to see the quantity of basses in your collection.");
            WriteLine("\"Count Other String Instruments\" to see the quantity of ukuleles in your collection.");
            WriteLine("\"Count Keyboards\" to see the quantity of keyboard instruments in your collection.");
            WriteLine("\"Save File\" to save a list of all your instruments to a text file.");
            WriteLine();
        }
    }
}
