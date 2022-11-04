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
        public static void PrintErrorMessage()
        {
            WriteLine("Invalid Command. Please type \"Commands\" to see a list of available commands or try again.");
            WriteLine();
        }

        public static void PrintAboutInfo()
        {
            WriteLine("MyInstruments was created by Nick Hill in 2022.");
            WriteLine();
            WriteLine("MyInstruments was developed as my capstone project for Session One of Code Kentucky's Software Development class.");
            WriteLine("The app was created to help me manage data about my collection of musical instruments.");
            WriteLine("It can be difficult to recall specific details about each instrument in my collection from memory.");
            WriteLine("I am often seeking out information like an instrument's string gauge, serial number and country or age of manufacture.");
            WriteLine("An interactive console app makes this process easier, faster and more fun!");
            WriteLine();
        }
    }
}
