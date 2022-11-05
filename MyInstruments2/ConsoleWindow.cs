using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
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
            WriteLine("Invalid Command. Please try again.");
            WriteLine();
        }

        public static void PrintReviewInstrumentsHeader()
        {
            PrintAppHeader();
            WriteLine();
            WriteLine("Type the key of the instrument that you wish to review.");
            WriteLine("Type \"Guitars\", \"Basses\", \"Keyboards\" or \"Other\" to see the keys available for review.");
            WriteLine("Type \"Menu\" to return the Main Menu.");
            WriteLine("Type \"Clear\" to clear the console.");
            WriteLine();
        }

        public static void PrintAboutInfo()
        {
            PrintAppHeader();
            WriteLine();
            WriteLine("MyInstruments was created by Nick Hill in 2022.");
            WriteLine();
            WriteLine("MyInstruments was developed as my capstone project for Session One of Code Kentucky's Software Development class.");
            WriteLine("The app was created to help me manage my collection of musical instruments.");
            WriteLine("It can be difficult to recall specific details about each instrument in my collection from memory.");
            WriteLine("I am often seeking out information like an instrument's string gauge, serial number and country or age of manufacture.");
            WriteLine("An interactive console app makes this process easier, faster and more fun!");
            WriteLine();
        }

        public static void PrintInstructions()
        {
            PrintAppHeader();
            WriteLine();
            WriteLine("Use the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.");
            WriteLine();
            WriteLine("\"Review Instruments\" allows you to review any instrument in my collection by typing its key into the console.");
            WriteLine();
            WriteLine("You may review the keys available to the program by typing \"Guitars\", \"Basses\", \"Keyboards\" or \"Other\".");
            WriteLine();
            WriteLine("Please note that keys are case specific and you will have to follow the case as indicated by the list for valid input.");
            WriteLine();
            WriteLine("If the console is becoming clogged with user input and data you may refresh it by typing \"Clear.\"");
            WriteLine();
            WriteLine("Type \"Menu\" to return to the Main Menu and select another option.");
            WriteLine();
            WriteLine("\"List Instruments\" shows a complete list of the keys available to the program.");
            WriteLine();
            WriteLine("\"Count Instruments\" provides a count of each instrument type and the total number of instruments in the collection.");
            WriteLine();
            WriteLine("\"Save Text File\" saves a list of the instrument keys to a .txt file in the temp folder on the C:\\ drive.");
            WriteLine("Tip: This can be a handy reference guide when woking in the \"Review Instruments\" component.");
            WriteLine();
            WriteLine("\"Exit\" will terminate the program.");
            WriteLine();
        }

        public static void PrintAppHeader()
        {
            WriteLine("███╗   ███╗██╗   ██╗██╗███╗   ██╗███████╗████████╗██████╗ ██╗   ██╗███╗   ███╗███████╗███╗   ██╗████████╗███████╗");
            WriteLine("████╗ ████║╚██╗ ██╔╝██║████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██║   ██║████╗ ████║██╔════╝████╗  ██║╚══██╔══╝██╔════╝");
            WriteLine("██╔████╔██║ ╚████╔╝ ██║██╔██╗ ██║███████╗   ██║   ██████╔╝██║   ██║██╔████╔██║█████╗  ██╔██╗ ██║   ██║   ███████╗");
            WriteLine("██║╚██╔╝██║  ╚██╔╝  ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██║   ██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║   ╚════██║");
            WriteLine("██║ ╚═╝ ██║   ██║   ██║██║ ╚████║███████║   ██║   ██║  ██║╚██████╔╝██║ ╚═╝ ██║███████╗██║ ╚████║   ██║   ███████║");
            WriteLine("╚═╝     ╚═╝   ╚═╝   ╚═╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝");
        }
    }
}
