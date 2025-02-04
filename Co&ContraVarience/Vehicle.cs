using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_ContraVarience
{
    internal class Vehicle
    {
        public Vehicle CreateVehicle()
        {
            Console.WriteLine("Vehicle created");
            return new Vehicle();
        }
        public void Display(Vehicle vehobj)
        {
            Console.WriteLine("Vehicles class Method" + vehobj);
        }

    }
    class Car : Vehicle
    {
        public Car CreateCar()
        {
            Console.WriteLine("Car Created");
            return new Car();
        }
        public void DisplayCar(Car carobj)
        {
            Console.WriteLine("Car class Method" + carobj);
        }
    }
}
    
