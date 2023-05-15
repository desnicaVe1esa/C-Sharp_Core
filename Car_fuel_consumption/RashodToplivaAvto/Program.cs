using System;

namespace RashodToplivaAvto
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford Mustang", 10, 14);
            car.Drive(10, Service.DistanceCalculator);
            car.Drive(15, Service.DistanceCalculator);
            car.Drive(45, Service.DistanceCalculatorWind);
            car.Drive(50, Service.DistanceCalculatorWind);
        }
    }
}
