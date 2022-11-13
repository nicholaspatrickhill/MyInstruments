﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine("Type the key of the guitar that you wish to review and press enter. Which guitar would you like to review?");

                string input = UserInput().ToLower();

                repeat = SelectGuitar(repeat, input);
            }

            static bool SelectGuitar(bool repeat, string input)
            {
                ForegroundColor = ConsoleColor.White;
                if (guitars.ContainsKey(input))
                {
                    Guitar guitarChoice = guitars[input];
                    guitarChoice.PrintInstrument();
                }
                else repeat = SelectCommand(repeat, input);
                return repeat;
            }
        }

        private static void ReviewBasses()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Basses:");
            Collection.PrintBassKeysArray();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine("Which bass would you like to review?");

                string input = UserInput().ToLower();

                repeat = SelectBass(repeat, input);
            }

            static bool SelectBass(bool repeat, string input)
            {
                ForegroundColor = ConsoleColor.White;
                if (basses.ContainsKey(input))
                {
                    Bass bassChoice = basses[input];
                    bassChoice.PrintInstrument();
                }
                else repeat = SelectCommand(repeat, input);
                return repeat;
            }
        }

        private static void ReviewOtherStringInstruments()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Other String Instruments:");
            Collection.PrintOtherStringInstrumentKeysArray();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine("Which other string instrument would you like to review?");

                string input = UserInput().ToLower();

                repeat = SelectOtherStringInstrument(repeat, input);
            }

            static bool SelectOtherStringInstrument(bool repeat, string input)
            {
                ForegroundColor = ConsoleColor.White;
                if (otherStringInstruments.ContainsKey(input))
                {
                    OtherStringInstrument otherStringInstrumentChoice = otherStringInstruments[input];
                    otherStringInstrumentChoice.PrintInstrument();
                }
                else repeat = SelectCommand(repeat, input);
                return repeat;
            }
        }

        private static void ReviewKeyboardInstruments()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Keyboards:");
            Collection.PrintKeyboardInstrumentKeysArray();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine("Which keyboard instrument would you like to review?");

                string input = UserInput().ToLower();

                repeat = SelectKeyboardInstrument(repeat, input);
            }

            static bool SelectKeyboardInstrument(bool repeat, string input)
            {
                ForegroundColor = ConsoleColor.White;
                if (keyboardInstruments.ContainsKey(input))
                {
                    KeyboardInstrument keyboardInstrumentChoice = keyboardInstruments[input];
                    keyboardInstrumentChoice.PrintInstrument();
                }
                else repeat = SelectCommand(repeat, input);
                return repeat;
            }
        }

        private static void ReviewFenderInstruments()
        {
            Clear();
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();
            WriteLine("Your Fender Instruments:");
            Collection.SearchForFenderInstruments();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine("Which Fender instrument would you like to review?");

                string input = UserInput().ToLower();

                repeat = SelectFenderInstrument(repeat, input);
            }

            static bool SelectFenderInstrument(bool repeat, string input)
            {
                ForegroundColor = ConsoleColor.White;
                if (guitars.ContainsKey(input))
                {
                    Guitar guitarChoice = guitars[input];
                    guitarChoice.PrintInstrument();
                }
                else if (basses.ContainsKey(input))
                {
                    Bass bassChoice = basses[input];
                    bassChoice.PrintInstrument();
                }
                else repeat = SelectCommand(repeat, input);
                return repeat;
            }
        }

        private static void ReturnToMainMenu()
        {
            MainMenu.Start();
        }
    }
}