using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        private double tankCapacity;
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }



        public double FuelQuantity { get; set; }
 
        public double FuelConsumption { get; set; }

        public double TankCapacity 
        {
            get => this.tankCapacity;
            set
            {
                this.tankCapacity = value;

                if(this.tankCapacity < this.FuelQuantity)
                {
                    this.FuelQuantity = 0;
                }
            }
        }



        public virtual void Drive(double distance)
        {

        }

        public virtual void Refuel(double fuel)
        {
            if(fuel > 0)
            {
                if (FuelQuantity + fuel <= TankCapacity)
                {
                    FuelQuantity += fuel;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            
        }

        public virtual void DriveEmpty(double amount)
        {

        }
    }
}
