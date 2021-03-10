using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double consumptionWithAirCondition = 0.9;

        private double currentConsumption;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void Drive(double distance)
        {
            currentConsumption = distance * (FuelConsumption + consumptionWithAirCondition);

            if (this.FuelQuantity >= currentConsumption)
            {
                FuelQuantity -= distance * (FuelConsumption + consumptionWithAirCondition);

                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
        }
    }
}
