using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments2.Ukulele;
using static MyInstruments2.Guitar;
using static MyInstruments2.Bass;
using static MyInstruments2.MusicalInstrument;

namespace MyInstruments2
{
    public class CheckInstruments
    {
        public static void Main(string[] args)
        {
             //--setting console size
            Console.SetWindowSize(138, 40);
            Console.ForegroundColor = ConsoleColor.White;

             //--calls the HeaderText method to start the program
            {
                Header.HeaderText();
            }

             //--loops through possible user inputs 
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
                    Console.WriteLine($"Your {guitar.instrumentName} is a {guitar.type} that was made in {guitar.country} in {guitar.year}.");
                    Console.WriteLine($"It is {guitar.instrumentAge} years old. It is {guitar.color} in color. Its serial number is {guitar.serial}.");
                    Console.WriteLine($"It uses {guitar.instrumentString} gauge strings.");
                    Console.WriteLine();
                }
                else if (basses.ContainsKey(input))
                { 
                    Bass bass = basses[input];
                    bass.PrintInstrument();
                }
               else if (ukuleles.ContainsKey(input))
               {
                    Ukulele ukulele = ukuleles[input];
                    ukulele.PrintInstrument();
                }
                else if (input == "All")
                {
                    MakeList.InstrumentInventory();
                }
                else if (input == "Guitars")
                {
                    Guitar guitar = new Guitar();
                    guitar.InstrumentList();
                }
                else if (input == "Basses")
                {
                    Bass bass = new Bass();
                    bass.InstrumentList();

                }
                else if (input == "Ukuleles")
                {
                    Ukulele ukulele = new Ukulele(); 
                    ukulele.InstrumentList();
                }
                else if (input == "Clear")
                {
                    Console.Clear();
                    Header.HeaderText(); //--calls on the HeaderText method after the console is cleared
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