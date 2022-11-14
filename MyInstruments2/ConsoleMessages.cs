using Spectre.Console;
using static System.Console;

namespace MyInstruments
{
    class ConsoleMessages
    {
        public static void PrintReviewAnyInstrumentHeader()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Type \"back\" to return to the previous menu.");
            WriteLine("-----------------------------------------------------------------------------------------------------------------");
        }

        public static void PrintAboutInfo()
        {
            PrintAppHeader();
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("MyInstruments was created by Nick Hill in 2022.");
            WriteLine();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("MyInstruments was developed as my capstone project for Session One of Code Kentucky's Software Development class.");
            WriteLine("The app was created to help me manage my collection of musical instruments.");
            WriteLine("It can be difficult to recall specific details about each instrument in my collection from memory.");
            WriteLine("I am often seeking out information like an instrument's string gauge, serial number and country or age of manufacture.");
            WriteLine("An interactive console app makes this process easier, faster and more fun!");
            ForegroundColor = ConsoleColor.White;
            WriteLine("----------------------------------------------------------------------------------------------------------------------");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(" The following features are demonstrated:");
            WriteLine(" --Create at least one class, then create at least one object of that class and populate it with data.");
            WriteLine(" --Create and call at least 3 functions or methods.");
            WriteLine(" --Implement a \"master loop\" console application where the user can enter commands.");
            WriteLine(" --Create an additional class which inherits one or more properties from its parent.");
            WriteLine(" --Create a dictionary or list, populate it with several values, and retrieve at least one value.");
            WriteLine(" --Create 3 or more unit tests for your application.");
            WriteLine(" --Calculate and display data based on an external factor.");
            WriteLine(" --Implement a log that records errors, invalid inputs, or other important events and writes them to a text file.");
            WriteLine(" --Visualize data in a graph, chart, or other visual representation of data.");
            WriteLine(" --Use a LINQ query to retrieve information from a data structure (such as a list or array) or file.");
        }

        public static void PrintInstructions()
        {
            PrintAppHeader();
            WriteLine();
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("Use the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.");
            WriteLine();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("In REVIEW INSTRUMENTS you may review any instrument in my collection by typing its key and pressing enter.");
            WriteLine(" --First, use the UP and DOWN arrow keys to select which type of instrument you wish to review and press enter.");
            WriteLine(" --Type any key from the displayed list and press enter to review data specific to that instrument.");
            WriteLine(" --Type \"back\" and press enter to return to the Main Menu and select another option.");
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("LIST INSTRUMENTS shows a complete list of the keys available to the program.");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("COUNT INSTRUMENTS displays a breakdown chart with the counts of each instrument type and displays.");
            WriteLine("The total number of instruments in the collection and the percentages of each instrument type are also displayed.");
            WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("SAVE TEXT FILE saves a list of the instrument keys to a .txt file in the temp folder on the C:\\ drive.");
            WriteLine(" --Tip: This can be a handy reference guide when woking in the \"Review Instruments\" module.");
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            WriteLine("EXIT will terminate the program upon confirmation.");
        }

        public static void PrintAppHeader()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("███╗   ███╗██╗   ██╗██╗███╗   ██╗███████╗████████╗██████╗ ██╗   ██╗███╗   ███╗███████╗███╗   ██╗████████╗███████╗");
            WriteLine("████╗ ████║╚██╗ ██╔╝██║████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██║   ██║████╗ ████║██╔════╝████╗  ██║╚══██╔══╝██╔════╝");
            WriteLine("██╔████╔██║ ╚████╔╝ ██║██╔██╗ ██║███████╗   ██║   ██████╔╝██║   ██║██╔████╔██║█████╗  ██╔██╗ ██║   ██║   ███████╗");
            WriteLine("██║╚██╔╝██║  ╚██╔╝  ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██║   ██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║   ╚════██║");
            WriteLine("██║ ╚═╝ ██║   ██║   ██║██║ ╚████║███████║   ██║   ██║  ██║╚██████╔╝██║ ╚═╝ ██║███████╗██║ ╚████║   ██║   ███████║");
            WriteLine("╚═╝     ╚═╝   ╚═╝   ╚═╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝");
        }
    }
}
