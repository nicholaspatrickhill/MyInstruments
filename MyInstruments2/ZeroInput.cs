using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments2
{
    public class ZeroInput
    {
        // this method is not working as intended yet. i want it to change my 0 values recorded for year and age to the word "unknown." 
        public static void YearConversion()
        {
            int Model = 0;
            if (Model == 0);
            {
                Convert.ToString(Model);

                string oldValue = Model.ToString();

                string newValue = Model.ToString().Replace("0", "unknown");

                Console.WriteLine(newValue);
            }
        }
    }
}