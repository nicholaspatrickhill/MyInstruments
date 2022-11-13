using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static MyInstruments.UserSelection;

namespace MyInstruments
{
    internal class UserReview
    {
        public static void ReviewAnyInstrument()
        {
            ConsoleMessage.PrintAppHeader();

            var repeat = true;
            while (repeat)
            {
                ConsoleMessage.PrintReviewAnyInstrumentHeader();

                WriteLine();
                string input = UserInput();

                repeat = SelectInstrument(repeat, input);
            }
        }

        private static string UserInput()
        {
            ForegroundColor = ConsoleColor.Cyan;
            var input = ReadLine().ToLower();
            return input;
        } 
    }
}
