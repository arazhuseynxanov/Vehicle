using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_11.Models
{
    internal  interface IEngine
    {
        public float OilCapacity { get; set; }
        public float CurrentOil { get; set; }
        public float FuelType { get; set; }

        float AverageSpeed();

        void RemainOilAmount()
        {
            Console.WriteLine(OilCapacity-CurrentOil);
        }

    }
}
