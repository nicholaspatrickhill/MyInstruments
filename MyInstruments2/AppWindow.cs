using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    class AppWindow
    {       
        public static void PrintHeader()
        {
            Console.WriteLine(".........................");
            Console.WriteLine("...   MyInstruments   ...");
            Console.WriteLine(".........................");
            Console.WriteLine();
            Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
            Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Quit\" to exit the program.");
            Console.WriteLine("Type \"Commands\" to view a list of other commands.");
            Console.WriteLine();
        }
        public static void ClearConsole()
        {
            Console.Clear();
            AppWindow.PrintHeader();
        }
        public static void PrintErrorMessage()
        {
            Console.WriteLine("That instrument is not in your collection. Please type \"All\" to see a list of all of your instruments or try again.");
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
            Console.WriteLine("\"Count All\" to see the total quantity of instruments in your collection.");
            Console.WriteLine("\"Count Guitars\" to see the quantity of guitars in your collection.");
            Console.WriteLine("\"Count Basses\" to see the quantity of basses in your collection.");
            Console.WriteLine("\"Count Ukuleles\" to see the quantity of ukuleles in your collection.");
            Console.WriteLine();
        }
    }
}
