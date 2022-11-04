using static MyInstruments.UserSelection;
using static System.Console;

// Fulfills feature list requirement: "Implement a log that records invalid inputs and writes them to a text file"
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MyInstruments
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleWindow.PrintHeader();

            /* Fulfills Feature List requirement: "Implement a “master loop” console application where the user 
                can repeatedly enter commands/perform actions, including choosing to exit the program" */
            var repeat = true;
            while (repeat)
            {
                WriteLine("Hello. What would you like to review?");

                var guitar = new Guitar();
                var bass = new Bass();
                var otherStringInstrument = new OtherStringInstrument();
                var keyboard = new KeyboardInstrument();
                string? input = UserInput();

                repeat = SelectInstrument(repeat, guitar, bass, otherStringInstrument, keyboard, input);
            }
        }

        private static string? UserInput()
        {
            ForegroundColor = ConsoleColor.Green;
            string? input = ReadLine();
            return input;
        }
    }
}

