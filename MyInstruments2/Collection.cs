﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.MusicalInstrument;
using static MyInstruments.KeyboardInstrument;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace MyInstruments
{
    class Collection
    {
        public static void CountAll()
        {
            int num1 = guitars.Count;
            int num2 = basses.Count;
            int num3 = otherStringInstruments.Count;
            int num4 = keyboards.Count;
            int num5 = num1 + num2 + num3 + num4;

            Console.WriteLine("You have " + num5 + " total instruments in your collection.");
            Console.WriteLine();
        }

        public static void ListAll()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            OtherStringInstrument otherStringInstrument = new OtherStringInstrument();
            KeyboardInstrument keyboardInstrument = new KeyboardInstrument();

            Console.WriteLine();
            Console.Write("Guitars:");
            guitar.ListInstruments();
            Console.Write("Basses:");
            bass.ListInstruments();
            Console.Write("Other String Instruments:");
            otherStringInstrument.ListInstruments();
            Console.Write("Keyboards:");
            keyboardInstrument.ListInstruments();
        }

        public static void CountInstrument(Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        {
            if (input == "Count Guitars")
            {
                guitar.CountInstruments();
            }
            else if (input == "Count Basses")
            {
                bass.CountInstruments();
            }
            else if (input == "Count Other String Instruments")
            {
                otherStringInstrument.CountInstruments();
            }
            else if (input == "Count Keyboards")
            {
                keyboard.CountInstruments();
            }
        }

        public static void ListInstrument(Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        {
            if (input == "Guitars")
            {
                guitar.ListInstruments();
            }
            else if (input == "Basses")
            {
                bass.ListInstruments();
            }
            else if (input == "Other String Instruments")
            {
                otherStringInstrument.ListInstruments();
            }
            else if (input == "Keyboards")
            {
                keyboard.ListInstruments();
            }
        }

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

            Console.WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
            Console.WriteLine();
        }
    }
}

