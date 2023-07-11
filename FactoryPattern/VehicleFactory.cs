using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   internal class VehicleFactory
   {
        //1. make this method static
        public static IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "suv":
                    return new SUV() { Color = "Black", FourWheelDrive = true};
                    
                case "truck":
                    return new Truck() { HasTowHitch = true, HasSafetyCameras = true};
                default:
                    return new Truck();
            }
        }
    }
}
