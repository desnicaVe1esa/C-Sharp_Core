using System;

namespace RashodToplivaAvto
{
    public static class Service
    {
        //метод вычисляет расход топлива при движении автомобиля в нормальных погодных условиях
        public static double DistanceCalculator(double fuelLevel, double fuelConsumption1Km, double distance)
        {
            fuelLevel -= distance * fuelConsumption1Km;
            if (fuelLevel <= 0)
                Console.WriteLine("Машина заглохла и не смогла проехать {0} км.", distance);
            else
                Console.WriteLine("Пройдена дистанция: {0} км. Осталось топлива в баке: {1} л.", distance, fuelLevel);

            return fuelLevel;
        }

        //метод вычисляет расход топлива при движении автомобиля в ветреную погоду
        public static double DistanceCalculatorWind(double fuelLevel, double fuelConsumption1Km, double distance)
        {
            fuelLevel -= distance * fuelConsumption1Km;
            fuelLevel -= 0.2; //поправка на ветер
            if (fuelLevel <= 0)
                Console.WriteLine("Машина заглохла и не смогла проехать {0} км.", distance);
            else
                Console.WriteLine("Пройдена дистанция: {0} км. Осталось топлива в баке: {1} л.", distance, fuelLevel);

            return fuelLevel;
        }
    }
}