using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.MusicalInstrument;
using static MyInstruments.KeyboardInstrument;
using static MyInstruments.UserSelection;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Console;
using BetterConsoleTables;
using System.Data;
using System.Net.NetworkInformation;

namespace MyInstruments
{
    class Collection
    {
        public static void ReviewAll()
        {
            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("Type \"Menu\" to return the Main Menu or type \"Clear\" to clear the console.");
                WriteLine("Which instrument would you like to review?");
                WriteLine();

                var guitar = new Guitar();
                var bass = new Bass();
                var otherStringInstrument = new OtherStringInstrument();
                var keyboard = new KeyboardInstrument();

                string? input = UserInput();

                repeat = SelectInstrument(repeat, guitar, bass, otherStringInstrument, keyboard, input);

                static string? UserInput()
                {
                    ForegroundColor = ConsoleColor.Green;
                    string? input = ReadLine();
                    return input;
                }
            }
        }
        public static void CountAll()
        {
            int num1 = guitars.Count;
            int num2 = basses.Count;
            int num3 = otherStringInstruments.Count;
            int num4 = keyboards.Count;
            int num5 = num1 + num2 + num3 + num4;

            WriteLine("You have " + num5 + " total instruments in your collection.");
            WriteLine();
            WriteLine("You have " + num1 + " guitars.");
            WriteLine("You have " + num2 + " basses.");
            WriteLine("You have " + num3 + " other string instruments.");
            WriteLine("You have " + num4 + " keyboard instruments.");
            WriteLine();

        }

        public static void ListAll()
        {
            var guitar = new Guitar();
            var bass = new Bass();
            var otherStringInstrument = new OtherStringInstrument();
            var keyboardInstrument = new KeyboardInstrument();

            WriteLine("Your instruments:");
            WriteLine();
            Write("Guitars:");
            guitar.ListInstruments();
            Write("Basses:");
            bass.ListInstruments();
            Write("Other String Instruments:");
            otherStringInstrument.ListInstruments();
            Write("Keyboards:");
            keyboardInstrument.ListInstruments();
        }

     
        //public static void CountInstrument(Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        //{
        //    if (input == "Count Guitars")
        //    {
        //        guitar.CountInstruments();
        //    }
        //    else if (input == "Count Basses")
        //    {
        //        bass.CountInstruments();
        //    }
        //    else if (input == "Count Other String Instruments")
        //    {
        //        otherStringInstrument.CountInstruments();
        //    }
        //    else if (input == "Count Keyboards")
        //    {
        //        keyboard.CountInstruments();
        //    }
        //}

        //public static void ListInstrument(Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        //{
        //    if (input == "Guitars")
        //    {
        //        guitar.ListInstruments();
        //    }
        //    else if (input == "Basses")
        //    {
        //        bass.ListInstruments();
        //    }
        //    else if (input == "Other String Instruments")
        //    {
        //        otherStringInstrument.ListInstruments();
        //    }
        //    else if (input == "Keyboards")
        //    {
        //        keyboard.ListInstruments();
        //    }
        //}

        public static void SaveFile()
        {
            string myInstruments = @"C:\temp\MyInstruments.txt";
            myInstruments = Path.GetFullPath(myInstruments);
            Directory.CreateDirectory(Path.GetDirectoryName(myInstruments));

            using StreamWriter file = new StreamWriter(myInstruments);
            {
                file.WriteLine("MY INSTRUMENTS");
                file.WriteLine();

                file.WriteLine("Guitars:");
                foreach (KeyValuePair<string, Guitar> entry in guitars)
                    file.WriteLine("{0}", entry.Key);
                file.WriteLine();

                file.WriteLine("Basses:");
                foreach (KeyValuePair<string, Bass> entry2 in basses)
                    file.WriteLine("{0}", entry2.Key);
                file.WriteLine();

                file.WriteLine("Other String Instruments:");
                foreach (KeyValuePair<string, OtherStringInstrument> entry3 in otherStringInstruments)
                    file.WriteLine("{0}", entry3.Key);
                file.WriteLine();

                file.WriteLine("Keyboards:");
                foreach (KeyValuePair<string, KeyboardInstrument> entry4 in keyboards)
                    file.WriteLine("{0}", entry4.Key);   
            }
            file.Close();

            WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
            WriteLine();
        }

    }
}

