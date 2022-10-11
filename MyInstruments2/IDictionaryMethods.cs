using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyInstruments
{
    interface IDictionaryMethods 
    {
        public void ListInstruments(); //--generates lists of each key in the dictionaries

        public void PrintInstrument(); //--prints the unique text body for each musical instrument object  
        
        public void CountInstruments(); //--counts the number of each collection of instruments 
    }
}
