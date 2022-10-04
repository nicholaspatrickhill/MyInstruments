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
    public class Program
    {
        public static void Main(string[] args)
        {
             //--sets console size & color
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
                
                Console.ForegroundColor = ConsoleColor.Green; //--sets user text to green
                string input = Console.ReadLine();
                
                Console.ForegroundColor= ConsoleColor.White; //--sets console text back to white

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
                    guitar.PrintInstrument();
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