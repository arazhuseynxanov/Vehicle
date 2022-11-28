using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_11.Models
{
    internal  class Plane:Vehicle
    {
        private float _wingLength;

        public float WingLength { get { return _wingLength; } set { _wingLength = value; } }

        public void override AverageSpeed();
    }

}
