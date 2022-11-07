using static MyInstruments.ReviewAllInstrumentsUserSelection;
using static System.Console;
using static MyInstruments.MainMenu;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MyInstruments
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainMenu.Start();
        }
    }
}

