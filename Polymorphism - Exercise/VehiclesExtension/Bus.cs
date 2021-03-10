using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double airConditionerOn = 1.4;
        private const double airConditionerOff = 0;
        private double currentConsumption;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void DriveEmpty(double distance)
        {
            currentConsumption = distance * (FuelConsumption + airConditionerOff);

            if (this.FuelQuantity >= currentConsumption)
            {

                FuelQuantity -= distance * (FuelConsumption + airConditionerOff);

                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
        }

        public override void Drive(double distance)
        {
            currentConsumption = distance * (FuelConsumption + airConditionerOn);

            if (this.FuelQuantity >= currentConsumption)
            {

                FuelQuantity -= distance * (FuelConsumption + airConditionerOn);

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
