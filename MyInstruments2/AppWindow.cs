﻿using System;
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
    }
}
