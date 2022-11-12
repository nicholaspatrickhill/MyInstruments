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
            string prompt = "\nWelcome to MyInstruments!\n\nUse the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.\nWhat would you like to do? \n";
            string[] options = { "Read Instructions", "Review Instruments", "List Instruments", "Count Instruments", "Save Text File", "About This App", "Exit" };
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
            ConsoleMessage.PrintInstructions();
            ReturnToMainMenu();
        }

        private static void ReviewInstruments()
        {
            Clear();
            UserReview.ReviewAnyInstrument();
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
            ConsoleMessage.PrintAboutInfo();
            ReturnToMainMenu();
        }

        private static void ExitProgram()
        {
            ExitTheProgram();
        }

        private void ReturnToMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private static void ExitTheProgram()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Are you sure you wish to exit the program?");
            WriteLine("Type \"y\" and press enter to exit or type \"n\" and press enter to return to the Main Menu.");

            ForegroundColor = ConsoleColor.Cyan;
            string input = ReadLine().ToLower();

            ForegroundColor = ConsoleColor.White;
            if (input == "y")
            {
                Environment.Exit(0);
            }
            else if (input == "n")
            {
                Start();
            }
            else
            {
                log4net.GlobalContext.Properties["UserInput"] = input;
                log.Error("Invalid User Input");
                WriteLine("Invalid Command. Please try again.");
                ExitProgram();
            }
        } 
    }
}
