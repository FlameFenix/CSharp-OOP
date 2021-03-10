using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Vehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string option = cmdArgs[0];
                string type = cmdArgs[1];
                double amount = double.Parse(cmdArgs[2]);

                if (option == "Drive" || option == "DriveEmpty")
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
                        else if (type == nameof(Bus) && option == "Drive")
                        {
                            bus.Drive(amount);
                        }
                        else if(type == nameof(Bus) && option == "DriveEmpty")
                        {
                            bus.DriveEmpty(amount);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (option == "Refuel")
                {
                    if (type == nameof(Car))
                    {
                        car.Refuel(amount);
                    }
                    else if (type == nameof(Truck))
                    {
                        truck.Refuel(amount);
                    }
                    else if(type == nameof(Bus))
                    {
                        bus.Refuel(amount);
                    }
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

            
    }
}
