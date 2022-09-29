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
                    Console.WriteLine();
                    MakeList2.InstrumentInventory2();
                    Console.WriteLine();
                }
                else if (input == "Guitars")
                {
                    Console.WriteLine();
                    Guitar.GuitarList();
                    Console.WriteLine();
                }
                else if (input == "Basses")
                {
                    Console.WriteLine();
                    Bass.BassList();
                    Console.WriteLine();
                }
                else if (input == "Ukuleles")
                {
                    Console.WriteLine();
                    Ukulele.UkuleleList();
                    Console.WriteLine();
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