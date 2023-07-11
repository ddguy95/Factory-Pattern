using System.ComponentModel.DataAnnotations;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1st vehicle
            Console.WriteLine("What type of vehicle do you want to make? A Truck or SUV?");
            string userInput = Console.ReadLine();

            //2. call the static method
           
           IVehicle myVehicle = VehicleFactory.CreateVehicle(userInput);

            myVehicle.Drive();


            //second vehicle
            Console.WriteLine("Let's make another vehicle.");
            userInput = Console.ReadLine();
            IVehicle yourVehicle = VehicleFactory.CreateVehicle(userInput);
            yourVehicle.Drive();
        }
    }
}
