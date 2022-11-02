using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Program;

namespace MyInstruments
{
    class ConsoleWindow
    {
        public static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "............................."));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", ".....   MyInstruments   ....."));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "............................."));
            Console.WriteLine();
            Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
            Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Commands\" to view a list of other commands.");
            Console.WriteLine("Type \"Quit\" to exit the program.");
            Console.WriteLine();
        }

        public static void ClearConsole()
        {
            Console.Clear();
            ConsoleWindow.PrintHeader();
        }

        public static void PrintErrorMessage()
        {
            Console.WriteLine("Invalid Command. Please type \"Commands\" to see a list of available commands or try again.");
            Console.WriteLine();
        }

        public static void PrintCommands()
        {
            Console.WriteLine();
            Console.WriteLine("Type...");
            Console.WriteLine("\"Quit\" to exit the program.");
            Console.WriteLine("\"Clear\" to clear the console.");
            Console.WriteLine("\"All\" to see a list of all of your instruments.");
            Console.WriteLine("\"Guitars\" to see a list of all of your guitars.");
            Console.WriteLine("\"Basses\" to see a list of all of your basses.");
            Console.WriteLine("\"Ukuleles\" to see a list of all of your Ukuleles.");
            Console.WriteLine("\"Banjos\" to see a list of all of your Banjos.");
            Console.WriteLine("\"Count All\" to see the total quantity of instruments in your collection.");
            Console.WriteLine("\"Count Guitars\" to see the quantity of guitars in your collection.");
            Console.WriteLine("\"Count Basses\" to see the quantity of basses in your collection.");
            Console.WriteLine("\"Count Ukuleles\" to see the quantity of ukuleles in your collection.");
            Console.WriteLine("\"Count Banjos\" to see the quantity of banjos in your collection.");
            Console.WriteLine("\"Print To File\" to print a list of all your instruments to a text file.");
            Console.WriteLine();
        }
    }
}
