using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;
using static MyInstruments.MusicalInstrument;
using System.Runtime.InteropServices;

namespace MyInstruments
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            AppWindow.PrintHeader();

            /* Fulfills Feature List requirement: "Implement a “master loop” console application where the user 
                can repeatedly enter commands/perform actions, including choosing to exit the program" */
            var repeat = true;
            while (repeat)
            {
                Console.WriteLine("Hello. Which instrument would you like to review?");

                var guitar = new Guitar();
                var bass = new Bass();
                var ukulele = new Ukulele();

                Console.ForegroundColor = ConsoleColor.Green;
                string? input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                repeat = SelectInstrument(repeat, guitar, bass, ukulele, input);
            }
        }

        private static bool SelectInstrument(bool repeat, Guitar guitar, Bass bass, Ukulele ukulele, string input)
        {
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
                        AppWindow.PrintCommands();
                        break;
                    case "All":
                        Collection.ListAll();
                        break;
                    case "Guitars":
                        guitar.ListInstruments();
                        break;
                    case "Basses":
                        bass.ListInstruments();
                        break;
                    case "Ukuleles":
                        ukulele.ListInstruments();
                        break;
                    case "Count All":
                        Collection.CountAll();
                        break;
                    case "Count Guitars":
                        guitar.CountInstruments();
                        break;
                    case "Count Basses":
                        bass.CountInstruments();
                        break;
                    case "Count Ukuleles":
                        ukulele.CountInstruments();
                        break;
                    case "Clear":
                        AppWindow.ClearConsole();
                        break;
                    default:
                        AppWindow.PrintErrorMessage();
                        break;
                }

                return repeat;
            }
        }
    }
}

