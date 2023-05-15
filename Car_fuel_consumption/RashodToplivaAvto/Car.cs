using System;

namespace RashodToplivaAvto
{
    public class Car
    {
        public delegate double DistanceCalculatorDelegate(double fuelLevel, double fuelConsumption1Km, double distance);

        public string Name { get; set; } //модель авто
        public double FuelLevel { get; set; } //сколько осталось топлива в баке
        private double fuelConsumption1Km { get; set; } //расход топлива на 1км

        public Car(string name, double fuelLevel, double fuelConsumption100Km)
        {
            Name = name;
            FuelLevel = fuelLevel;
            fuelConsumption1Km = fuelConsumption100Km / 100 * 1;
        }

        public void Drive(double distance, DistanceCalculatorDelegate dDelegate)
        {
            FuelLevel = dDelegate(FuelLevel, fuelConsumption1Km, distance);
        }
    }
}