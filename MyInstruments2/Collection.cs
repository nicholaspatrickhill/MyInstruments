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
            ConsoleWindow.PrintReviewInstrumentsHeader();

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
            WriteLine();
        }

        //public static void ListAllInstruments()
        //{
        //    var guitar = new Guitar();
        //    var bass = new Bass();
        //    var otherStringInstrument = new OtherStringInstrument();
        //    var keyboardInstrument = new KeyboardInstrument();

        //    ConsoleWindow.PrintAppHeader();
        //    WriteLine();
        //    WriteLine("Your instruments:");
        //    WriteLine();
        //    Write("Guitars:");
        //    guitar.ListInstruments();
        //    Write("Basses:");
        //    bass.ListInstruments();
        //    Write("Other String Instruments:");
        //    otherStringInstrument.ListInstruments();
        //    Write("Keyboards:");
        //    keyboardInstrument.ListInstruments();
        //}

        //public static void ListInstrumentsByType(Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        //{
        //    if (input == "Guitars")
        //    {
        //        guitar.ListInstruments();
        //    }
        //    else if (input == "Basses")
        //    {
        //        bass.ListInstruments();
        //    }
        //    else if (input == "Other")
        //    {
        //        otherStringInstrument.ListInstruments();
        //    }
        //    else if (input == "Keyboards")
        //    {
        //        keyboard.ListInstruments();
        //    }
        //}

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

            ConsoleWindow.PrintAppHeader();
            WriteLine();
            WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
            WriteLine();
        }

        //public static void ListInstrumentsInTable()
        //{
        //    ConsoleWindow.PrintAppHeader();
        //    WriteLine();

        //    ConsoleTableBuilder
        //        .From(guitars
        //            .Select(guitar => new object[]
        //            {
        //                guitar.Key,
        //            })
        //            .ToList())
        //        .WithColumn("GUITARS")
        //        .WithFormat(ConsoleTableBuilderFormat.Minimal)
        //        .ExportAndWriteLine();
        //    WriteLine();

        //    ConsoleTableBuilder
        //      .From(basses
        //          .Select(bass => new object[]
        //          {
        //                bass.Key,
        //          })
        //          .ToList())
        //      .WithColumn("BASSES")
        //      .WithFormat(ConsoleTableBuilderFormat.Minimal)
        //      .ExportAndWriteLine();
        //    WriteLine();

        //    ConsoleTableBuilder
        //      .From(otherStringInstruments
        //          .Select(otherStringInstrument => new object[]
        //          {
        //                otherStringInstrument.Key,
        //          })
        //          .ToList())
        //      .WithColumn("OTHER STRING INSTRUMENTS")
        //      .WithFormat(ConsoleTableBuilderFormat.Minimal)
        //      .ExportAndWriteLine();
        //    WriteLine();

        //    ConsoleTableBuilder
        //      .From(keyboards
        //          .Select(keyboard => new object[]
        //          {
        //                keyboard.Key,
        //          })
        //          .ToList())
        //      .WithColumn("KEYBOARD INSTRUMENTS")
        //      .WithFormat(ConsoleTableBuilderFormat.Minimal)
        //      .ExportAndWriteLine();
        //    WriteLine();
        //}

        //public static void ListInstrumentsInColumns()
        //{
        //    List<string> guitarKeyList = new List<string>(guitars.Keys);
        //    List<string> bassKeyList = new List<string>(basses.Keys);
        //    List<string> otherStringInstrumentKeyList = new List<string>(otherStringInstruments.Keys);
        //    List<string> keyboardsKeyList = new List<string>(keyboards.Keys);

        //    var count1 = guitarKeyList.Count;
        //    var count2 = bassKeyList.Count;

        //    for (var i = 0; i < Math.Max(count1, count2); i++)
        //    {
        //        Console.WriteLine(String.Format("{0,-10} | {1,-10}",
        //                                        i < count1 ? guitarKeyList[i] : string.Empty,
        //                                        i < count2 ? bassKeyList[i] : string.Empty));
        //    }

        //}

        public static void ListOfInstruments()
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
            WriteLine();
        }


    }
}


