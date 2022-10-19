using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyInstruments
{
    interface IMusicalInstrument
    {
        public void ListInstruments();

        public void PrintInstrument();

        public void CountInstruments();
    }
}
