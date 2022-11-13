using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.UserCommands;
using static System.Console;

namespace MyInstruments
{
    public class UserSelection
    {
        public static bool SelectInstrument(bool repeat, string input)
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
            else if (keyboardInstruments.ContainsKey(input)) 
            {
                KeyboardInstrument keyboardInstrumentChoice = keyboardInstruments[input];
                keyboardInstrumentChoice.PrintInstrument();
            } 

            else repeat = SelectCommand(repeat, input);
            return repeat;
        }
    }  
}
