using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;
using static MyInstruments.MusicalInstrument;
using static MyInstruments.UserSelection;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;

namespace MyInstruments
{
    class Program
    {
        public static void Main(string[] args)
        { 
            ConsoleWindow.PrintHeader();

            /* Fulfills Feature List requirement: "Implement a “master loop” console application where the user 
                can repeatedly enter commands/perform actions, including choosing to exit the program" */
            var repeat = true;
            while (repeat)
            {
                Console.WriteLine("Hello. Which instrument would you like to review?");

                var guitar = new Guitar();
                var bass = new Bass();
                var ukulele = new Ukulele();
                string? input = UserInput();

                repeat = SelectInstrument(repeat, guitar, bass, ukulele, input);
            }
        }

        private static string? UserInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string? input = Console.ReadLine();
            return input;
        }
    }
}

