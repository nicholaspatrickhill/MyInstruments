using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.UserSelection;
using static System.Console;

namespace MyInstruments
{
    public class Game
    {
        public void Start()
        {
            Title = "MyInstruments";        
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
            string prompt = @".............................
.....   MyInstruments   .....
.............................

Welcome to MyInstruments. What would you like to do? 
Use the arrow keys to cycle through options and press enter to select an option.
";
            string[] options = { "Review Instruments", "List Instruments", "Count Instruments", "Save Text File", "About", "Exit" };
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
                    SaveAFile();
                    break;
                case 4:
                    DisplayAboutInfo();
                    break;
                case 5:
                    ExitProgram();
                    break;
            }
        }

        private void ReviewInstruments()
        {
            Clear();
            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("Type \"Menu\" to return the Main Menu or type \"Clear\" to clear the console.");
                WriteLine("Which instrument would you like to review?");
                WriteLine();

                var guitar = new Guitar();
                var bass = new Bass();
                var otherStringInstrument = new OtherStringInstrument();
                var keyboard = new KeyboardInstrument();

                string? input = UserInput();

                repeat = SelectInstrument(repeat, guitar, bass, otherStringInstrument, keyboard, input);

                static string? UserInput()
                {
                    ForegroundColor = ConsoleColor.Green;
                    string? input = ReadLine();
                    return input;
                }
            }
            
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

        private void SaveAFile()
        {
            Clear();
            Collection.SaveFile();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("This console app was created by Nick Hill in 2022.");
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
