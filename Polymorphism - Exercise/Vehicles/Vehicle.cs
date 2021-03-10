using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
 
        public double FuelConsumption { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public virtual void Drive(double distance)
        {

        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}
