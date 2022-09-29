using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    internal class Header
    {
         //--this method prints the Header text to start the program and after the console has been cleared
        public static void HeaderText()
        {
            Console.WriteLine("........................");
            Console.WriteLine("...  MyInstruments2  ...");
            Console.WriteLine("........................");
            Console.WriteLine();
            Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
            Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Quit\" to exit the program.");
            Console.WriteLine("Type \"Commands\" to view a list of other commands.");
            Console.WriteLine();
        }
    }
}
