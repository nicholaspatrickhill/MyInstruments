﻿using static System.Console;
using static MyInstruments.UserSelection;

namespace MyInstruments
{
    internal class UserReview
    {
        public static void ReviewAnyInstrument()
        {
            ConsoleMessages.PrintAppHeader();
            ConsoleMessages.PrintReviewAnyInstrumentHeader();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine("What would you like to review?");

                string input = UserInput();

                repeat = SelectInstrument(repeat, input);
            }
        }

        private static string UserInput()
        {
            ForegroundColor = ConsoleColor.Cyan;
            string input = ReadLine().ToLower();
            return input;
        } 
    }
}
