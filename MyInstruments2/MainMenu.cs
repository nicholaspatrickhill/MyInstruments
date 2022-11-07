﻿using System;
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
        public static void Start()
        {
            var mainMenu = new MainMenu();
            mainMenu.RunMainMenu();
        }

        private void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
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

        private void ReviewInstruments()
        {
            Clear();
            Collection.ReviewAllInstruments();
        }

        private void ListInstruments()
        {
            Clear();
            Collection.ListOfAllInstruments();
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

        private void ExitProgram()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void ReturnToMainMenu()
        {
            WriteLine();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
    }
}
