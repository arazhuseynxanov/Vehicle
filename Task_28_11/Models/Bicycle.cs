using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_11.Models
{
    internal class Bicycle:Vehicle
    {
        private string _pedalKind;

        public string PedalKind { get; set; }


        public  Bicycle(string pedalKind)
        {
            PedalKind = pedalKind;
        }
        public void override AverageSpeed();
    }
}
