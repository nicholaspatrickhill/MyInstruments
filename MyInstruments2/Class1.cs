//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static MyInstruments.Guitar;
//using static MyInstruments.Bass;
//using static MyInstruments.Ukulele;
//using static MyInstruments.MusicalInstrument;

//namespace MyInstruments
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
            
//            Console.ForegroundColor = ConsoleColor.White;
//            AppWindow.PrintHeader();

//            /*--Fulfills Feature List requirement: "Implement a “master loop” console application where the user 
//              can repeatedly enter commands/perform actions, including choosing to exit the program" */
//            while (true)
//            Console.WriteLine("Hello. Which instrument would you like to review?");

//            var allUkuleles = Ukulele.ukuleles;
//            Ukulele.ChooseUkulele();
          

            
//            {
//                string input = Console.ReadLine();
//                switch (input)
//                {
//                    case "Quit":
//                        {
//                            repeat = false;

//                        }
//                        break;
//                    case "Commands":
//                        {
//                            Commands.PrintCommands();
//                        }
//                        break;
//                    case "Guitar":
//                        {
//                            if (guitars.ContainsKey(input))
//                            {
//                                Guitar guitar = guitars[input];
//                                guitar.PrintInstrument();

//                            }
//                        }
//                        break;
//                    case "Bass":
//                        {
//                            if (basses.ContainsKey(input))
//                            {
//                                Bass bass = basses[input];
//                                bass.PrintInstrument();
//                            }
//                        }
//                        break;
//                    case "Ukulele":
//                        {
//                            if (ukuleles.ContainsKey(input))
//                            {
//                                Ukulele ukulele = ukuleles[input];
//                                ukulele.PrintInstrument();
//                            }
//                        }
//                        break;
//                    case "All":
//                        {
//                            Collection.ListAll();
//                        }
//                        break;
//                    case "Guitars":
//                        {
//                            Guitar guitar = new Guitar();
//                            guitar.ListInstruments();
//                        }
//                        break;
//                    case "Basses":
//                        {
//                            Bass bass = new Bass();
//                            bass.ListInstruments();
//                        }
//                        break;
//                    case "Ukuleles":
//                        {
//                            Ukulele ukulele = new Ukulele();
//                            ukulele.ListInstruments();
//                        }
//                        break;
//                    case "Count All":
//                        {
//                            Collection.CountAll();
//                        }
//                        break;
//                    case "Count Guitars":
//                        {
//                            Guitar guitar = new Guitar();
//                            guitar.CountInstruments();
//                        }
//                        break;
//                    case "Count Basses":
//                        {
//                            Bass bass = new Bass();
//                            bass.CountInstruments();
//                        }
//                        break;
//                    case "Count Ukuleles":
//                        {
//                            Ukulele ukulele = new Ukulele();
//                            ukulele.CountInstruments();
//                        }
//                        break;
//                    case "Clear":
//                        {
//                            Console.Clear();
//                            Header.PrintHeader(); //--calls on the HeaderText method after the console is cleared
//                        }
//                        break;
//                    default:
//                        {
//                            Console.WriteLine("That instrument is not in your collection. Please type \"All\" to see a list of all of your instruments or try again.");
//                            Console.WriteLine();
//                        }
//                        break;
//                }
//            }

//        }
//    }
//}
