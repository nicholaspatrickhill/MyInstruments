using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.UserSelection;
using static System.Console;

namespace MyInstruments
{
    public class MainMenu
    {
        public void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
            string prompt = @".......................................
..........   MyInstruments   ..........
.......................................

Welcome to MyInstruments! What would you like to do? 
Use the arrow keys to cycle through options and press enter to select an option.
";
            string[] options = { "Review Instruments", "List Instruments", "Count Instruments", "Save Text File", "Instructions", "About This App", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ReviewInstruments();
                    break;
                case 1:
                    ListInstruments();
                    break;
                case 2:
                    CountInstruments();
                    break;
                case 3:
                    SaveTextFile();
                    break;
                case 4:
                    DisplayInstructions();
                    break;
                case 5:
                    DisplayAboutInfo();
                    break;
                case 6:
                    ExitProgram();
                    break;
            }
        }

        private void ReviewInstruments()
        {
            Clear();
            Collection.ReviewAll();
        }

        private void ListInstruments()
        {
            Clear();
            Collection.ListAll();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void CountInstruments()
        {
            Clear();
            Collection.CountAll();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void SaveTextFile()
        {
            Clear();
            Collection.SaveFile();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void DisplayInstructions()
        {
            Clear();
            ConsoleWindow.PrintInstructions();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void DisplayAboutInfo()
        {
            Clear();
            ConsoleWindow.PrintAboutInfo();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void ExitProgram()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
