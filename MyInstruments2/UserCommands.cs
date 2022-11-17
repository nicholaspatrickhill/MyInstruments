namespace MyInstruments
{
    public class UserCommands
    {
        public static void SelectCommand(string input)
        {
            switch (input)
            {
                case "menu":
                case "back":
                    ReviewInstrumentsMenu.RunReviewInstrumentsMenu();
                    break;
                default:
                    ConsoleMessages.PrintInvalidInputResponse(input);
                    break;
            }
        }
    }
}
