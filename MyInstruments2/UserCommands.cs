﻿using log4net;
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
        public static bool SelectCommand(bool repeat, string input)
        {
            switch (input)
            {
                case "help":
                    ConsoleWindow.PrintHelp();
                    break;
                case "clear":
                    Clear();
                    Collection.ReviewAnyInstrument();
                    break;
                case "menu":
                    MainMenu.Start();
                    break; 
                case "guitars": 
                case "basses":
                case "other":
                case "keyboards":
                    Collection.ListInstrumentsByType(input);
                    break;
                default:
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    WriteLine("Invalid Command. Please try again.");
                    break;
            }

            return repeat;
        }
    }
}
