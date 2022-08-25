using PYP_Task_Instrument.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Instrument.Models
{
    public class Piano : Instrument
    {
        public int Keyboard { get; set; }
        public override string Sound()
        {
            return "sound piano";
        }
    }
}
