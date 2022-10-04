using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class Commands
    {
         //--prints all of the commands available to the user in the console app
        public static void CommandList() 
        {
            Console.WriteLine();
            Console.WriteLine("Type \"Quit\" to exit the program.");
            Console.WriteLine("Type \"Clear\" to clear the console.");
            Console.WriteLine("Type \"All\" to see a list of all of your instruments.");
            Console.WriteLine("Type \"Guitars\" to see a list of all of your guitars.");
            Console.WriteLine("Type \"Basses\" to see a list of all of your basses.");
            Console.WriteLine("Type \"Ukulele\" to see a list of all of your Ukuleles.");   
            Console.WriteLine();
        }
    }
}
