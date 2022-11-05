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

Welcome to MyInstruments!  
Use the UP and DOWN arrow keys to highlight the function that you wish to perform and then press enter.

What would you like to do?
";
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

        private void ReviewInstruments()
        {
            Clear();
            Collection.ReviewAll();
        }

        private void ListInstruments()
        {
            Clear();
            WriteLine();
            Collection.ListAll();
            ReturnToMainMenu();
        }

        private void CountInstruments()
        {
            Clear();
            Collection.CountAll();
            ReturnToMainMenu();
        }

        private void SaveTextFile()
        {
            Clear();
            Collection.SaveFile();
            ReturnToMainMenu();
        }

        private void DisplayAboutInfo()
        {
            Clear();
            ConsoleWindow.PrintAboutInfo();
            ReturnToMainMenu();
        }

        private void ExitProgram()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void ReturnToMainMenu()
        {
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
    }
}
