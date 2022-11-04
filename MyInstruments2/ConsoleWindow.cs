using Microsoft.VisualBasic.FileIO;
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

        public static void PrintInstructions()
        {
            WriteLine("The easiest way to get started is to select \"List Instruments\".");
            WriteLine("This generates a list of the keys that correspond to the musical instruments that are available for review.");
            WriteLine();
            WriteLine("Then return to the main menu and select \"Review Instruments.\"");
            WriteLine("Here you can review any individual instrument in my collection by typing the key exactly as it appeared in the list.");
            WriteLine("**Please note that keys are case specific and you will have to follow the case as indicated by the list for valid input");
            WriteLine();
            WriteLine("If the console is becoming clogged with user input and data you may refresh it by typing \"Clear.\"");
            WriteLine();
            WriteLine("Type \"Menu\" to return to the Main Menu and select another option.");
            WriteLine();
            WriteLine("\"Count Instruments\" will provide a count of each instrument type and the total number of instruments in the collection.");
            WriteLine();
            WriteLine("\"Save Text File\" will save a list of the instrument keys to a .txt file in the temp folder on the C drive.");
            WriteLine("Tip: This can be a handy reference guide when woking in the \"Review Instruments\" component. ");
            WriteLine();
            WriteLine("\"Exit\" will terminate the program.");
            WriteLine();
        }
    }
}
