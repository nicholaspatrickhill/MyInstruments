using static MyInstruments.UserSelection;
using static System.Console;
using static MyInstruments.MainMenu;

// Fulfills feature list requirement: "Implement a log that records invalid inputs and writes them to a text file"
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MyInstruments
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Fulfills Feature List requirement: "Implement a “master loop” console application where the user 
                can repeatedly enter commands/perform actions, including choosing to exit the program" */        

            var mainMenu = new MainMenu();
            mainMenu.RunMainMenu();
        }
    }
}

