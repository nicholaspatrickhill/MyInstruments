using static System.Console;

namespace MyInstruments
{
    class ConsoleWindow
    {
        public static void PrintErrorMessage()
        {
            WriteLine("Invalid Command. Please try again.");
        }

        public static void PrintReviewInstrumentsHeader()
        {
            ForegroundColor = ConsoleColor.White;
            PrintAppHeader();
            WriteLine();
            WriteLine("Type the key of the instrument that you wish to review.");
            WriteLine("Type \"Guitars\", \"Basses\", \"Keyboards\" or \"Other\" to see the keys available for review.");
            WriteLine("Type \"Menu\" to return the Main Menu.");
            WriteLine("Type \"Clear\" to clear the console.");
        }

        public static void PrintAboutInfo()
        {
            ForegroundColor = ConsoleColor.White;
            PrintAppHeader();
            WriteLine();
            WriteLine("MyInstruments was created by Nick Hill in 2022.");
            WriteLine();
            WriteLine("MyInstruments was developed as my capstone project for Session One of Code Kentucky's Software Development class.");
            WriteLine("The app was created to help me manage my collection of musical instruments.");
            WriteLine("It can be difficult to recall specific details about each instrument in my collection from memory.");
            WriteLine("I am often seeking out information like an instrument's string gauge, serial number and country or age of manufacture.");
            WriteLine("An interactive console app makes this process easier, faster and more fun!");
        }

        public static void PrintInstructions()
        {
            ForegroundColor = ConsoleColor.White;
            PrintAppHeader();
            WriteLine();
            WriteLine("Use the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.");
            WriteLine();
            WriteLine("In \"Review Instruments\" you may review any instrument in my collection by typing its key and then pressing enter.");
            WriteLine();
            WriteLine("You may review the keys available to the program by typing \"Guitars\", \"Basses\", \"Keyboards\" or \"Other\" and then pressing enter.");
            WriteLine();
            WriteLine("Please note that keys are case specific and you will need to follow the case as indicated by the list for valid input.");
            WriteLine();
            WriteLine("If the console is becoming clogged with user input and data you may refresh it by typing \"Clear.\" and then pressing enter");
            WriteLine();
            WriteLine("Type \"Menu\" and press enter to return to the Main Menu and select another option.");
            WriteLine();
            WriteLine("\"List Instruments\" shows a complete list of the keys available to the program.");
            WriteLine();
            WriteLine("\"Count Instruments\" provides a count of each instrument type and the total number of instruments in the collection.");
            WriteLine();
            WriteLine("\"Save Text File\" saves a list of the instrument keys to a .txt file in the temp folder on the C:\\ drive.");
            WriteLine("Tip: This can be a handy reference guide when woking in the \"Review Instruments\" module.");
            WriteLine();
            WriteLine("\"Exit\" will terminate the program upon confirmation.");
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
