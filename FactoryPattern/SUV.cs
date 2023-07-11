using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SUV : IVehicle
    {
        public bool FourWheelDrive { get; set; }
        public string Color { get; set; }
        public void Drive()
        {
            Console.WriteLine($"My {Color} SUV is running and is ready to drive!");
        }
        
    }
}
