using PYP_Task_Instrument.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Instrument.Models
{
    public class Drum : Instrument
    {
        public int Cymbal { get; set; }
        public override string Sound()
        {
            return "sound drum";
        }
    }
}
