using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyInstruments.Guitar;
using static MyInstruments.Bass;
using static MyInstruments.OtherStringInstrument;
using static MyInstruments.KeyboardInstrument;
using static System.Console;

namespace MyInstruments
{
    public class CollectionCount
    {
        private static readonly int guitarsCount = guitars.Count;
        private static readonly int bassesCount = basses.Count;
        private static readonly int otherCount = otherStringInstruments.Count;
        private static readonly int keyboardsCount = keyboardInstruments.Count;
        private static readonly int totalCount = guitarsCount + bassesCount + otherCount + keyboardsCount;

        public static void DisplayAllInstrumentCounts()
        {
            ConsoleMessage.PrintAppHeader();
            WriteLine();
            WriteLine();            
            PrintInstrumentBreakDownChart();
            PrintTotalInstrumentCount();
            PrintInstrumentPercentages();
        }

        private static void PrintInstrumentBreakDownChart()
        {
            AnsiConsole.Write(new BreakdownChart()
                .Width(65)
                .AddItem("Guitars", guitarsCount, Color.Red)
                .AddItem("Basses", bassesCount, Color.Blue)
                .AddItem("Other String Instruments", otherCount, Color.Green)
                .AddItem("Keyboard Instruments", keyboardsCount, Color.Yellow));
        }

        private static void PrintTotalInstrumentCount()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("You have " + totalCount + " total instruments in your collection.");
            WriteLine();
        }

        private static void PrintInstrumentPercentages()
        {
            int guitarPercent = (int)Math.Round(((double)guitarsCount / (double)totalCount) * 100);
            WriteLine($"{guitarPercent}% of your instruments are guitars.");

            int bassPercent = (int)Math.Round(((double)bassesCount / (double)totalCount) * 100);
            WriteLine($"{bassPercent}% of your instruments are basses.");

            int otherStringInstrumentPercent = (int)Math.Round(((double)otherCount / (double)totalCount) * 100);
            WriteLine($"{otherStringInstrumentPercent}% of your instruments are other string instruments.");

            int keyboardInstrumentsPercent = (int)Math.Round(((double)keyboardsCount / (double)totalCount) * 100);
            WriteLine($"{keyboardInstrumentsPercent}% of your instruments are keyboard instruments.");
        }
    }
}
