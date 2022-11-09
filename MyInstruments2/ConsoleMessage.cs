using static System.Console;
using static MyInstruments.Collection;

namespace MyInstruments
{
    class ConsoleMessage
    {
        public static void PrintReviewAnyInstrumentHeader()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Type the key of the instrument that you wish to review and press enter. Type \"help\" for a list of other commands.");
            WriteLine("What would you like to review?");
        }

        public static void PrintGuitarsKeyList()
        {
            ForegroundColor = ConsoleColor.Red;
            guitarsKeyList.ForEach(WriteLine);
        }

        public static void PrintBassesKeyList()
        {
            ForegroundColor = ConsoleColor.Blue;
            bassesKeyList.ForEach(WriteLine);
        }

        public static void PrintKeyboardInstrumentsKeyList()
        {
            ForegroundColor = ConsoleColor.Yellow;
            keyboardInstrumentsKeyList.ForEach(WriteLine);
        }

        public static void PrintOtherStringInstrumentsKeyList()
        {
            ForegroundColor = ConsoleColor.Green;
            otherStringInstrumentsKeyList.ForEach(WriteLine);
        }

        public static void PrintHelp()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("Type \"guitars\" to see the guitar keys available for review.");
            WriteLine("Type \"basses\" to see the bass keys available for review.");
            WriteLine("Type \"other\" to see the other string instrument keys available for review.");
            WriteLine("Type \"keyboards\" to see the keyboard instrument keys available for review.");
            WriteLine("Type \"menu\" to return home to the Main Menu.");
            WriteLine("Type \"clear\" to clear the console and start over.");
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
            WriteLine("In \"Review Instruments\" you may review any instrument in my collection by typing its key and pressing enter.");
            WriteLine(" --Please note that all user keys and commands are lower case specific for valid input.");
            WriteLine(" --You may review the keys available by typing \"guitars\", \"basses\", \"keyboards\" or \"other\" and then pressing enter.");
            WriteLine(" --If the console is becoming clogged with text you may refresh it by typing \"clear\" and pressing enter");
            WriteLine(" --Type \"menu\" and press enter to return to the Main Menu and select another option.");
            WriteLine();
            WriteLine("\"List Instruments\" shows a complete list of the keys available to the program.");
            WriteLine();
            WriteLine("\"Count Instruments\" provides a count of each instrument type and the total number of instruments in the collection.");
            WriteLine();
            WriteLine("\"Save Text File\" saves a list of the instrument keys to a .txt file in the temp folder on the C:\\ drive.");
            WriteLine(" -Tip: This can be a handy reference guide when woking in the \"Review Instruments\" module.");
            WriteLine();
            WriteLine("\"Exit\" will terminate the program upon confirmation.");
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
