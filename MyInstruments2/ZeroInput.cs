﻿using System;
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
            int modelYear = 0;
            if (modelYear == 0) ;
            {
                Convert.ToString(modelYear);

                string oldValue = modelYear.ToString();

                string newValue = modelYear.ToString().Replace("0", "unknown");

                Console.WriteLine(newValue);
            }
        }
    }
}