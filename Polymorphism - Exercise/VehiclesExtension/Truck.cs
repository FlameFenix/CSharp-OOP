using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double consumptionWithAirCondition = 1.6;
        private double currentConsumption;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
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
            if(fuel * 0.95 <= TankCapacity)
            {
                base.Refuel(fuel * 0.95);
            }
            else
            {
                base.Refuel(fuel);
            }
        }
    }
}
