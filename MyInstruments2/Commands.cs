using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    public class Commands
    {
         // Prints all of the commands available to the user in the console app
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
