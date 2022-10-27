using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;
using static MyInstruments.MusicalInstrument;

namespace MyInstruments
{
    public class UserSelection
    {
        public static bool SelectInstrument(bool repeat, Guitar guitar, Bass bass, Ukulele ukulele, string input)
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
            else repeat = SelectCommand(repeat, guitar, bass, ukulele, input);

            return repeat;

            static bool SelectCommand(bool repeat, Guitar guitar, Bass bass, Ukulele ukulele, string input)
            {
                switch (input)
                {
                    case "Quit":
                        repeat = false;
                        break;
                    case "Commands":
                        ConsoleWindow.PrintCommands();
                        break;
                    case "All":
                        Collection.ListAll();
                        break;
                    case "Clear":
                        ConsoleWindow.ClearConsole();
                        break;
                    case "Guitars":
                    case "Basses":
                    case "Ukuleles":
                        Collection.ListInstrument(guitar, bass, ukulele, input);
                        break;
                    case "Count All":
                        Collection.CountAll();
                        break;
                    case "Count Guitars":
                    case "Count Basses":
                    case "Count Ukuleles":
                        Collection.CountInstrument(guitar, bass, ukulele, input);
                        break;
                    default:
                        ConsoleWindow.PrintErrorMessage();
                        break;
                }

                return repeat;
            }
        }
    }
}
