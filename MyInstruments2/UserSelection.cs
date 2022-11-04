using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.MusicalInstrument;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.UserCommands;
using static System.Console;

namespace MyInstruments
{
    public class UserSelection
    {
        public static bool SelectInstrument(bool repeat, Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
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
            else if (otherStringInstruments.ContainsKey(input))
            {
                OtherStringInstrument oherStringInstrumentChoice = otherStringInstruments[input];
                oherStringInstrumentChoice.PrintInstrument();
            }
            else if (keyboards.ContainsKey(input)) 
            {
                KeyboardInstrument keyboardChoice = keyboards[input];
                keyboardChoice.PrintInstrument();
            } 
            
            else repeat = SelectCommand(repeat, guitar, bass, otherStringInstrument, keyboard, input);
            return repeat;
        }
    }  
}
