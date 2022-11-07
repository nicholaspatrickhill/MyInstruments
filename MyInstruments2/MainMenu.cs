using static System.Console;

namespace MyInstruments
{
    public class MainMenu
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public static void Start()
        {
            var mainMenu = new MainMenu();
            mainMenu.RunMainMenu();
        }

        private void RunMainMenu()
        {
            
            string prompt = "\nWelcome to MyInstruments!\nUse the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.\n\nWhat would you like to do? \n";
            string[] options = { "Instructions", "Review Instruments", "List Instruments", "Count Instruments", "Save Text File", "About This App", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    DisplayInstructions();
                    break;
                case 1:
                    ReviewInstruments();
                    break;
                case 2:
                    ListInstruments();
                    break;
                case 3:
                    CountInstruments();
                    break;
                case 4:
                    SaveTextFile();
                    break;
                case 5:
                    DisplayAboutInfo();
                    break;
                case 6:
                    ExitProgram();
                    break;
            }
        }

        private void DisplayInstructions()
        {
            Clear();
            ConsoleWindow.PrintInstructions();
            ReturnToMainMenu();
        }

        private static void ReviewInstruments()
        {
            Clear();
            Collection.ReviewAnyInstrument();
        }

        private void ListInstruments()
        {
            Clear();
            Collection.ListAllInstruments();
            ReturnToMainMenu();
        }

        private void CountInstruments()
        {
            Clear();
            Collection.CountAllInstruments();
            ReturnToMainMenu();
        }

        private void SaveTextFile()
        {
            Clear();
            Collection.SaveInstrumentsToTextFile();
            ReturnToMainMenu();
        }

        private void DisplayAboutInfo()
        {
            Clear();
            ConsoleWindow.PrintAboutInfo();
            ReturnToMainMenu();
        }

        private static void ExitProgram()
        {
            ExitTheProgram();
        }

        private void ReturnToMainMenu()
        {
            WriteLine();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private static void ExitTheProgram()
        {
            WriteLine();
            WriteLine("Are you sure you wish to exit the program?");
            WriteLine("Type \"Y\" and press enter to exit or type \"N\" and press enter to return to the Main Menu.");

            ForegroundColor = ConsoleColor.Cyan;
            string input = ReadLine();

            ForegroundColor = ConsoleColor.White;

            if (input == "Y")
            {
                Environment.Exit(0);
            }
            else if (input == "N")
            {
                Start();
            }
            else
            {
                log4net.GlobalContext.Properties["UserInput"] = input;
                log.Error("Invalid User Input");
                ConsoleWindow.PrintErrorMessage();
                ExitProgram();
            }
        }
    }
}
