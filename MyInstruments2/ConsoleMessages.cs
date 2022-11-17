using static System.Console;

namespace MyInstruments
{
    class ConsoleMessages
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public static void PrintInvalidInputResponse(string input)
        {
            ForegroundColor = ConsoleColor.White;
            log4net.GlobalContext.Properties["UserInput"] = input;
            log.Error("Invalid User Input");
            WriteLine();
            WriteLine("Invalid Command. Please try Again");
        }

        public static void PrintReviewAnyInstrumentHeader()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Type the full name of the instrument that you wish to review & press enter. Type \"back\" to return to the previous menu.");
            WriteLine("-----------------------------------------------------------------------------------------------------------------------");
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
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
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
            WriteLine("In REVIEW INSTRUMENTS you may review any individual instrument in my collection.");
            WriteLine(" --First, use the UP and DOWN arrow keys to select which type of instrument you wish to review and press enter.");
            WriteLine(" --The names of all of the instruments of that type will be displayed on the console.");
            WriteLine(" --Type the full name of the instrument that you wish to reivew and press enter.");
            WriteLine(" --The console will display the data specific to that instrument.");
            WriteLine(" --When you are finished reviewing the data, press any key to start again.");
            WriteLine(" --Type \"back\" and press enter to return to the Main Menu and select another option.");
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("LIST INSTRUMENTS shows a complete list of the instruments in the collection.");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("COUNT INSTRUMENTS displays a breakdown chart with the counts of each instrument type and displays.");
            WriteLine("The total number of instruments in the collection and the percentages of each instrument type are also displayed.");
            WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("SAVE TEXT FILE saves a list of the instrument keys to a .txt file in the temp folder on the C:\\ drive.");
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
