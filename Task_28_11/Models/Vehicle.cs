using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_11.Models
{
    internal abstract class Vehicle : IEngine
    {
        private float _driveTime;
        private float _drivePath;

        public float DriveTime
        {
            get { return _drivePath; }
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
            }
        }
        public float Drivepath
        {
            get { return _drivePath; }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }

        public float OilCapacity { get; set; }
        public float CurrentOil { get; set; }
        public float FuelType { get; set; }

        public Vehicle(float driveTime, float drivePath)
        {
            DriveTime = driveTime;
            Drivepath = drivePath;
        }



        public virtual float AverageSpeed()
        {
            Drivepath / DriveTime;
        };
      



    }
}
