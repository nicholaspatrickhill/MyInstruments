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
        public static bool SelectCommand(bool repeat, Guitar guitar, Bass bass, Ukulele ukulele, string input)
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
                case "Ukuleles":
                    Collection.ListInstrument(guitar, bass, ukulele, input);
                    break;
                case "Count All":
                    Collection.CountAll();
                    break;
                case "Count Guitars":
                case "Count Basses":
                case "Count Ukuleles":
                    Collection.CountInstrument(guitar, bass, ukulele, input);
                    break;
                case "Print":
                case "Print to File":
                    Collection.PrintAllToFile();
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
