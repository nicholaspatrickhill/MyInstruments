using static System.Console;

namespace MyInstruments
{
    public class UserCommands
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public static void SelectCommand(string input)
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
                    WriteLine("Invalid Command. Please try again.");
                    break;
            }
        }
    }
}
