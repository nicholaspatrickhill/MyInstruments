using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments2.Ukulele;
using static MyInstruments2.Guitar;
using static MyInstruments2.Bass;

namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
            // setting console size
            Console.SetWindowSize(138, 40);
            Console.ForegroundColor = ConsoleColor.White;

            // header code to start the program
            Console.WriteLine("........................");
            Console.WriteLine("...  MyInstruments2  ...");
            Console.WriteLine("........................");
            Console.WriteLine();
            Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
            Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Quit\" to exit the program.");
            Console.WriteLine("Type \"Commands\" to view a list of other commands.");
            Console.WriteLine();

            // loops through possible user inputs 
            while (true)
            {
                Console.WriteLine("Hello. Which instrument would you like to review?");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.ForegroundColor= ConsoleColor.White;

                if (input == "Quit")
                {
                    break;
                }
                else if (input == "Commands")
                {
                    Commands.CommandList();
                }
                else if (guitars.ContainsKey(input))
                {
                    Guitar guitar = guitars[input];
                    Console.WriteLine($"Your {guitar.InstrumentName} is a {guitar.Type} that was made in {guitar.Country} in {guitar.Year}.");
                    Console.WriteLine($"It is {guitar.InstrumentAge} years old. It is {guitar.Color} in color. Its serial number is {guitar.Serial}.");
                    Console.WriteLine($"It uses {guitar.InstrumentString} gauge strings.");
                    Console.WriteLine();
                }
                else if (basses.ContainsKey(input))
                { 
                    Bass bass = basses[input];
                    Console.WriteLine($"Your {bass.InstrumentName} is a {bass.Type} that was made in {bass.Country} in {bass.Year}.");
                    Console.WriteLine($"It is {bass.InstrumentAge} years old. It is {bass.Color} in color. It is a {bass.Scale} scale bass. Its serial number is {bass.Serial}.");
                    Console.WriteLine($"It uses {bass.InstrumentString} gauge strings.");
                    Console.WriteLine();
                }
               else if (ukuleles.ContainsKey(input))
                {
                    Ukulele ukulele = ukuleles[input];
                    Console.WriteLine($"Your {ukulele.InstrumentName} is a {ukulele.Type} that was made in {ukulele.Country} in {ukulele.Year}.");
                    Console.WriteLine($"It is {ukulele.InstrumentAge} years old. It is {ukulele.Color} in color. It is a {ukulele.Size} sized instrument. Its serial number is {ukulele.Serial}.");
                    Console.WriteLine();
                }
                else if (input == "All")
                {
                    MakeList.InstrumentInventory();
                    Console.WriteLine();
                }
                else if (input == "Guitars")
                {
                    Console.WriteLine();
                    foreach (KeyValuePair<string, Guitar> pair in guitars)
                        Console.WriteLine(pair.Key);
                        Console.WriteLine();
                }
                else if (input == "Basses")
                {
                    Console.WriteLine();
                    foreach (KeyValuePair<string, Bass> pair in basses)
                        Console.WriteLine(pair.Key);
                    Console.WriteLine();
                }
                else if (input == "Clear")
                {
                    Console.Clear();
                    Console.WriteLine("........................");
                    Console.WriteLine("...  MyInstruments2  ...");
                    Console.WriteLine("........................");
                    Console.WriteLine();
                    Console.WriteLine("Welcome to MyInstruments! To get started, please type the name of the instrument that you would like to review.");
                    Console.WriteLine("Type \"All\" to see a list of all of your instruments. Type \"Quit\" to exit the program. Type \"Clear\" to clear the console and start over.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("That instrument is not in your collection. Please type \"All\" to see a list of all of your instruments or try again.");
                    Console.WriteLine();
                }
            }
        }
    }
}