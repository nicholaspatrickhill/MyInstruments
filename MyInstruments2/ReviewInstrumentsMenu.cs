using static System.Console;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.UserCommands;

namespace MyInstruments
{
    public class ReviewInstrumentsMenu
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public static void RunReviewInstrumentsMenu()
        {
            string prompt = "\nUse the UP and DOWN arrow keys to highlight the instruments that you wish to review and then press enter.\n";
            string[] options = { "Guitars", "Basses", "Other String Instruments", "Keyboards", "Fenders", "Return To Main Menu" };
            Menu userReviewAnyInstrumentMenu = new Menu(prompt, options);
            int selectedIndex = userReviewAnyInstrumentMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ReviewGuitars();
                    break;
                case 1:
                    ReviewBasses();
                    break;
                case 2:
                    ReviewOtherStringInstruments();
                    break;
                case 3:
                    ReviewKeyboardInstruments();
                    break;
                case 4:
                    ReviewFenderInstruments();
                    break;
                case 5:
                    ReturnToMainMenu();
                    break;
            }
        }
        private static string UserInput()
        {
            ForegroundColor = ConsoleColor.Cyan;
            string input = ReadLine() ?? string.Empty;
            return input;
        }

        private static void ReviewGuitars()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Guitars:");
            Collection.PrintGuitarKeysArray();

            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Which guitar would you like to review?");

            string input = UserInput().ToLower();

            ForegroundColor = ConsoleColor.White;
            if (guitars.ContainsKey(input))
            {
                Guitar guitarChoice = guitars[input];
                WriteLine();
                guitarChoice.PrintInstrument();
            }
            else SelectCommand(input);

            ReturnToGuitarMenu();
        }

        private static void ReviewBasses()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Basses:");
            Collection.PrintBassKeysArray();

            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Which bass would you like to review?");

            string input = UserInput().ToLower();

            ForegroundColor = ConsoleColor.White;
            if (basses.ContainsKey(input))
            {
                Bass bassChoice = basses[input];
                WriteLine();
                bassChoice.PrintInstrument();
            }
            else SelectCommand(input);

            ReturnToBassMenu();
        }

        private static void ReviewOtherStringInstruments()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Other String Instruments:");
            Collection.PrintOtherStringInstrumentKeysArray();

            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Which string instrument would you like to review?");

            string input = UserInput().ToLower();

            ForegroundColor = ConsoleColor.White;
            if (otherStringInstruments.ContainsKey(input))
            {
                OtherStringInstrument otherStringInstrumentChoice = otherStringInstruments[input];
                WriteLine();
                otherStringInstrumentChoice.PrintInstrument();
            }
            else SelectCommand(input);

            ReturnToOtherStringInstrumentsMenu();
        }

        private static void ReviewKeyboardInstruments()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Keyboards:");
            Collection.PrintKeyboardInstrumentKeysArray();

            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Which keyboard instrument would you like to review?");

            string input = UserInput().ToLower();

            ForegroundColor = ConsoleColor.White;
            if (keyboardInstruments.ContainsKey(input))
            {
                KeyboardInstrument keyboardInstrumentChoice = keyboardInstruments[input];
                WriteLine();
                keyboardInstrumentChoice.PrintInstrument();
            }
            else SelectCommand(input);

            ReturnToKeyBoardInstrumentsMenu();
        }

        private static void ReviewFenderInstruments()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Fender Instruments:");
            Collection.SearchForFenderInstruments();


            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Which Fender instrument would you like to review?");

            string input = UserInput().ToLower();

            var guitarKeys = guitars.Keys.Any(key => key.Contains("fender"));

            ForegroundColor = ConsoleColor.White;
            if (guitars.ContainsKey(input))
            {
                if (input.Contains("fender"))
                {
                    Guitar guitarChoice = guitars[input];
                    WriteLine();
                    guitarChoice.PrintInstrument();
                }
                else
                {
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    WriteLine();
                    WriteLine("Invalid Command. Please try again.");
                }
            }
            else if (basses.ContainsKey(input))
            {
                if (input.Contains("fender"))
                {
                    Bass bassChoice = basses[input];
                    WriteLine();
                    bassChoice.PrintInstrument();
                }
                else
                {
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    WriteLine();
                    WriteLine("Invalid Command. Please try Again");
                }
            }
            else SelectCommand(input);

            ReturnToFenderInstrumentsMenu();
        }

        private static void ReturnToMainMenu()
        {
            MainMenu.Start();
        }

        private static void StartAgain()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Press any key to start again.");
            ReadKey(true);
        }

        private static void ReturnToGuitarMenu()
        {
            StartAgain();
            ReviewGuitars();
        }

        private static void ReturnToBassMenu()
        {
            StartAgain();
            ReviewBasses();
        }

        private static void ReturnToOtherStringInstrumentsMenu()
        {
            StartAgain();
            ReviewOtherStringInstruments();
        }

        private static void ReturnToKeyBoardInstrumentsMenu()
        {
            StartAgain();
            ReviewKeyboardInstruments();
        }

        private static void ReturnToFenderInstrumentsMenu()
        {
            StartAgain();
            ReviewFenderInstruments();
        }
    }
}
