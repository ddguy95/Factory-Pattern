using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Truck : IVehicle
    {
        public bool HasTowHitch { get; set; }
        public bool HasSafetyCameras { get; set; }

        public void Drive()
        {
            Console.WriteLine("The Truck is running and is ready to drive!");
            
        }
    }
}
