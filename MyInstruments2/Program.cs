using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MyInstruments.Ukulele;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.MusicalInstrument;

namespace MyInstruments
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.White;

            // Calls the HeaderText method to start the program
            {
                Header.PrintHeader();
            }

            /* Fulfills Feature List requirement: "Implement a “master loop” console application where the user 
                can repeatedly enter commands/perform actions, including choosing to exit the program" */
            while (true)
            {
                Console.WriteLine("Hello. Which instrument would you like to review?");

                Guitar guitar = new Guitar();
                Bass bass = new Bass();
                Ukulele ukulele = new Ukulele();

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;

                if (input == "Quit")
                {
                    break;
                }

                else if (input == "Commands")
                {
                    Commands.PrintCommands();
                }

                else if (guitars.ContainsKey(input))
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
                
                else if (input == "All")
                {
                    Collection.ListAll();
                }
                
                else if (input == "Guitars")
                {
                    guitar.ListInstruments();
                }
                
                else if (input == "Basses")
                {   
                    bass.ListInstruments();
                }
               
                else if (input == "Ukuleles")
                {
                    ukulele.ListInstruments();
                }
                
                else if (input == "Count All")
                {
                    Collection.CountAll();
                }
                
                else if (input == "Count Guitars")
                {
                    guitar.CountInstruments();
                }
                
                else if (input == "Count Basses")
                {
                    bass.CountInstruments();
                }
                
                else if (input == "Count Ukuleles")
                {
                    ukulele.CountInstruments();
                }
                
                else if (input == "Clear")
                {
                    AppWindow.ClearConsole();
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