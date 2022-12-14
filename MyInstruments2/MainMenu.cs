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
                    ExitTheProgram();
                    break;
            }
        }

        private void DisplayInstructions()
        {
            Clear();
            ConsoleMessages.PrintInstructions();
            ReturnToMainMenu();
        }

        private static void ReviewInstruments()
        {
            Clear();
            ReviewInstrumentsMenu.RunReviewInstrumentsMenu();
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
            CollectionCounts.DisplayAllInstrumentCounts();
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
            ConsoleMessages.PrintAboutInfo();
            ReturnToMainMenu();
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
            string prompt = "\nAre you sure you wish to exit the program?";
            string[] options = { "\nyes", "no" };

            Menu exitMenu = new Menu(prompt, options);
            int selectedIndex = exitMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nRock on...");
                    Environment.Exit(0);
                    break;
                case 1:
                    Start();
                    break;
            }
        }   
    }
}
