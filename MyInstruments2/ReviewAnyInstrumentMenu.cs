using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyInstruments
{
    
    public class ReviewAnyInstrumentMenu
    {
        public static void StartReviewAnyInstrumentMenu()
        {
            var reviewAnyInstrumentMenu = new ReviewAnyInstrumentMenu();
            reviewAnyInstrumentMenu.RunReviewAnyInstrumentMenu();
        }
        private void RunReviewAnyInstrumentMenu()
        {
            string prompt = "\nUse the UP and DOWN arrow keys to highlight the instrument type that you wish to review and then press enter.\n";
            string[] options = { "Guitars", "Basses", "Other String Instruments", "Keyboard Instruments", "Return to Home Menu" };
            Menu reviewAnyInstrumentMenu = new Menu(prompt, options);
            int selectedIndex = reviewAnyInstrumentMenu.Run();

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
                case 4:
                    ReviewKeyboardInstruments();
                    break;
                case 5:
                    ReturnToHomeMenu();
                    break;
            }
        }

        private void ReviewGuitars()
        {
            ConsoleWindow.PrintGuitarsKeyList();
        }

        private void ReviewBasses()
        {

        }

        private void ReviewOtherStringInstruments()
        {

        }

        private void ReviewKeyboardInstruments()
        {


        }

        private static void ReturnToHomeMenu()
        {
            Clear();
            MainMenu.Start();
        }

        
    }
}
