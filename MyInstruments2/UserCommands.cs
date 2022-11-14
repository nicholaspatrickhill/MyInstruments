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
                case "menu":
                case "back":
                    ReviewInstrumentsMenu.RunReviewInstrumentsMenu();
                    break;
                default:
                    log4net.GlobalContext.Properties["UserInput"] = input;
                    log.Error("Invalid User Input");
                    WriteLine();
                    WriteLine("Invalid Command. Try again or type \"back\" to return to the main menu.");
                    break;
            }

            return repeat;
        }
    }
}
