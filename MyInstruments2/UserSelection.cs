using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;
using static MyInstruments.MusicalInstrument;
using static MyInstruments.Banjo;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.UserCommands;

namespace MyInstruments
{
    public class UserSelection
    {
        public static bool SelectInstrument(bool repeat, Guitar guitar, Bass bass, Ukulele ukulele, Banjo banjo, KeyboardInstrument keyboard, string input)
        {
            Console.ForegroundColor = ConsoleColor.White;

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
            else if (ukuleles.ContainsKey(input))
            {
                Ukulele ukuleleChoice = ukuleles[input];
                ukuleleChoice.PrintInstrument();
            }
            else if (banjos.ContainsKey(input))
            {
                Banjo banjoChoice = banjos[input];
                banjoChoice.PrintInstrument();
            }
            else if (keyboards.ContainsKey(input)) 
            {
                KeyboardInstrument keyboardChoice = keyboards[input];
                keyboardChoice.PrintInstrument();
            }
            else repeat = SelectCommand(repeat, guitar, bass, ukulele, banjo, keyboard, input);
            return repeat;
        }
    }  
}
