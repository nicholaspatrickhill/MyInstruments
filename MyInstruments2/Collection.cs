using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.Ukulele;
using static MyInstruments.MusicalInstrument;
using static MyInstruments.Banjo;
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
            int num3 = ukuleles.Count;
            int num4 = banjos.Count;
            int num5 = keyboards.Count;
            int num6 = num1 + num2 + num3 + num4 + num5;

            Console.WriteLine("You have " + num6 + " total instruments in your collection.");
            Console.WriteLine();
        }

        public static void ListAll()
        {
            Guitar guitar = new Guitar();
            Bass bass = new Bass();
            Ukulele ukulele = new Ukulele();
            Banjo banjo = new Banjo();
            KeyboardInstrument keyboardInstrument = new KeyboardInstrument();

            Console.WriteLine();
            Console.Write("Guitars:");
            guitar.ListInstruments();
            Console.Write("Basses:");
            bass.ListInstruments();
            Console.Write("Ukuleles:");
            ukulele.ListInstruments();
            Console.Write("Banjos:");
            banjo.ListInstruments();
            Console.Write("Keyboards:");
            keyboardInstrument.ListInstruments();
        }

        public static void CountInstrument(Guitar guitar, Bass bass, Ukulele ukulele, Banjo banjo, KeyboardInstrument keyboard, string input)
        {
            if (input == "Count Guitars")
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
            else if (input == "Count Banjos")
            {
                banjo.CountInstruments();
            }
            else if (input == "Count Keyboards")
            {
                keyboard.CountInstruments();
            }
        }

        public static void ListInstrument(Guitar guitar, Bass bass, Ukulele ukulele, Banjo banjo, KeyboardInstrument keyboard, string input)
        {
            if (input == "Guitars")
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
            else if (input == "Banjos")
            {
                banjo.ListInstruments();
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

                file.WriteLine("Ukuleles:");
                foreach (KeyValuePair<string, Ukulele> entry3 in ukuleles)
                    file.WriteLine("{0}", entry3.Key);
                file.WriteLine();

                file.WriteLine("Banjos:");
                foreach (KeyValuePair<string, Banjo> entry4 in banjos)
                    file.WriteLine("{0}", entry4.Key);
                file.WriteLine();

                file.WriteLine("Keyboards:");
                foreach (KeyValuePair<string, KeyboardInstrument> entry5 in keyboards)
                    file.WriteLine("{0}", entry5.Key);   
            }
            file.Close();

            Console.WriteLine("Your instruments have been saved to a text file at C:\\temp\\MyInstruments.txt.");
            Console.WriteLine();
        }
    }
}

