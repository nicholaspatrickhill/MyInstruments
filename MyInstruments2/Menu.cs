using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyInstruments
{
    internal class Menu
    {
        //public void Start()

        //{

        //    ConsoleKeyInfo keyPressed = Console.ReadKey();

        //    if (keyPressed.Key == ConsoleKey.Enter)
        //    {
        //        Console.WriteLine("You pressed Enter");
        //    }
        //    else if (keyPressed.Key == ConsoleKey.UpArrow)
        //    {
        //        WriteLine("You pressed the UP ARROW");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You pressed another key");
        //    }

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey(true);
        //}

        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                WriteLine($"<< {currentOption} >>");
            }
        }
    }
}
