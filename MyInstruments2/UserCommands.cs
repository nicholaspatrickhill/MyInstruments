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
                    ConsoleMessages.PrintHelp();
                    break;
                case "clear":
                    Clear();
                    UserReview.ReviewAnyInstrument();
                    break;
                case "menu":
                case "back":
                    MainMenu.Start();
                    break;
                case "guitars":
                case "basses":
                case "other":
                case "keyboards":
                    Collection.ListInstrumentsByType(input);
                    break;
                case "fenders":
                    Collection.SearchForFenderInstruments();
                    break;
                default:
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    WriteLine("Invalid Command. Type \"menu\" to return to the main menu or type \"help\" for a list of other commands.");
                    break;
            }

            return repeat;
        }
    }
}
