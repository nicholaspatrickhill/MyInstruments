using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyInstruments
{
    public class UserCommands
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public static bool SelectCommand(bool repeat, Guitar guitar, Bass bass, OtherStringInstrument otherStringInstrument, KeyboardInstrument keyboard, string input)
        {
            switch (input)
            {
                case "Clear":
                    Clear();
                    ConsoleWindow.PrintHeader();
                    break;
                case "Menu":
                    var mainMenu = new MainMenu();
                    mainMenu.RunMainMenu();
                    break; 
                case "Guitars": 
                case "Basses":
                case "Other":
                case "Keyboards":
                    Collection.ListInstrumentsByType(guitar, bass, otherStringInstrument, keyboard, input);
                    break;
                default:
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    ConsoleWindow.PrintErrorMessage();
                    break;
            }
            return repeat;
        }
    }
}
