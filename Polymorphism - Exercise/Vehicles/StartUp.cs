using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string option = cmdArgs[0];
                string type = cmdArgs[1];
                double amount = double.Parse(cmdArgs[2]);

                if(option == "Drive")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Drive(amount);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Drive(amount);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
                else if(option == "Refuel")
                {
                    if (type == nameof(Car))
                    {
                        car.Refuel(amount);
                    }
                    else if (type == nameof(Truck))
                    {
                        truck.Refuel(amount);
                    }
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
