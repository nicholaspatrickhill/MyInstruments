using static System.Console;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MyInstruments
{
    class Program
    {
        public static void Main(string[] args)
        {
            Title = "MyInstruments";
            MainMenu.Start();
        }
    }
}

