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
using ConsoleTableExt;
using Spectre.Console;
using System.Runtime.CompilerServices;

namespace MyInstruments
{
    class Collection
    {
        public static List<string> guitarsKeyList = new List<string>(guitars.Keys);
        public static List<string> bassesKeyList = new List<string>(basses.Keys);
        public static List<string> otherStringInstrumentsKeyList = new List<string>(otherStringInstruments.Keys);
        public static List<string> keyboardInstrumentsKeyList = new List<string>(keyboards.Keys);

        public static void ReviewAllInstruments()
        {
            ConsoleWindow.PrintInstrumentsHeader();

            var repeat = true;
            while (repeat)
            {
                ForegroundColor = ConsoleColor.White;

                WriteLine("Which instrument would you like to review?");

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

        public static void CountAllInstruments()
        {
            int num1 = guitars.Count;
            int num2 = basses.Count;
            int num3 = otherStringInstruments.Count;
            int num4 = keyboards.Count;
            int num5 = num1 + num2 + num3 + num4;

            ConsoleWindow.PrintAppHeader();
            WriteLine();
            WriteLine("You have " + num1 + " guitars.");
            WriteLine("You have " + num2 + " basses.");
            WriteLine("You have " + num3 + " other string instruments.");
            WriteLine("You have " + num4 + " keyboard instruments.");
            WriteLine();
            WriteLine("You have " + num5 + " total instruments in your collection.");
        }

        public static void ListInstrumentsByType(string input)
        {
            if (input == "Guitars")
            {
                guitarsKeyList.ForEach(WriteLine);
            }
            else if (input == "Basses")
            {
                bassesKeyList.ForEach(WriteLine);
            }
            else if (input == "Other")
            {
                otherStringInstrumentsKeyList.ForEach(WriteLine);
            }
            else if (input == "Keyboards")
            {
                keyboardInstrumentsKeyList.ForEach(WriteLine);
            }
            WriteLine();
        }

        public static void SaveInstrumentsToTextFile()
        {
            string myInstruments = @"C:\temp\MyInstruments.txt";
            myInstruments = Path.GetFullPath(myInstruments);
            Directory.CreateDirectory(Path.GetDirectoryName(myInstruments));

            using StreamWriter file = new StreamWriter(myInstruments);
            {
                file.WriteLine("MY INSTRUMENTS");
                file.WriteLine();

                file.WriteLine("Guitars:");
                guitarsKeyList.ForEach(file.WriteLine);
                file.WriteLine();

                file.WriteLine("Basses:");
                bassesKeyList.ForEach(file.WriteLine);
                file.WriteLine();

                file.WriteLine("Other String Instruments:");
                otherStringInstrumentsKeyList.ForEach(file.WriteLine);
                file.WriteLine();

                file.WriteLine("Keyboards:");
                keyboardInstrumentsKeyList.ForEach(file.WriteLine);
            }
            file.Close();

            ConsoleWindow.PrintAppHeader();
            WriteLine();
            WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
        }

        public static void ListOfAllInstruments()
        {
            ConsoleWindow.PrintAppHeader();
            WriteLine();
            WriteLine("Your instruments:");
            WriteLine();
            WriteLine("Guitars:");
            guitarsKeyList.ForEach(WriteLine);
            WriteLine();
            WriteLine("Basses:");
            bassesKeyList.ForEach(WriteLine);
            WriteLine();
            WriteLine("Other String Instruments:");
            otherStringInstrumentsKeyList.ForEach(WriteLine);
            WriteLine();
            WriteLine("Keyboards:");
            keyboardInstrumentsKeyList.ForEach(WriteLine);
        }

    }
}


