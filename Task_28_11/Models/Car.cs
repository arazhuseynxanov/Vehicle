using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_11.Models
{
    internal class Car:Vehicle
    {
        private int _doorCount;

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value > 1)
                {
                    _doorCount = value;
                }
            }
        }
        public Car(int doorCount)
        {
            DoorCount = doorCount;
            
        }
        public void  override AverageSpeed();

    }
}
