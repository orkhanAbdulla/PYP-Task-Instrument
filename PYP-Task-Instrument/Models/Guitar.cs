using PYP_Task_Instrument.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Instrument.Models
{
    public class Guitar : Instrument
    {
        public int CountOfWires { get; set; }
        public override string Sound()
        {
            return "sound guitar";
        }
    }
}
