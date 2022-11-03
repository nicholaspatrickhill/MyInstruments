using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    public class UserCommands
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public static bool SelectCommand(bool repeat, Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        {
            switch (input)
            {
                case "Quit":
                    repeat = false;
                    break;
                case "Commands":
                    ConsoleWindow.PrintCommands();
                    break;
                case "All":
                    Collection.ListAll();
                    break;
                case "Clear":
                    ConsoleWindow.ClearConsole();
                    break;
                case "Guitars":
                case "Basses":
                case "Other String Instruments":
                case "Keyboards":
                    Collection.ListInstrument(guitar, bass, otherStringInstrument, keyboard, input);
                    break;
                case "Count All":
                    Collection.CountAll();
                    break;
                case "Count Guitars":
                case "Count Basses":
                case "Count Other String Instruments":
                case "Count Keyboards":
                    Collection.CountInstrument(guitar, bass, otherStringInstrument, keyboard, input);
                    break;
                case "Save":
                case "Save File":
                    Collection.SaveFile();
                    break;
                default:
                    // Fulfills feature list requirement: "Implement a log that records invalid inputs and writes them to a text file"
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    ConsoleWindow.PrintErrorMessage();
                    break;
            }
            return repeat;
        }
    }
}
