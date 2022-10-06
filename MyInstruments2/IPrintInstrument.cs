using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInstruments
{
    interface IPrintInstrument //--this interface is used by the musical instrument classes to generate their unique console replies
    {
        public void PrintInstrument();
    }
}
