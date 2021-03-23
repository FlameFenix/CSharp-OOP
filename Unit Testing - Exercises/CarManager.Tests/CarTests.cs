using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("make", "model", 1.0, 5.0);
        }

        [Test]
        public void CheckFuelAmount()
        {
            Assert.That(car.FuelAmount == 0);
        }

        [Test]
        public void CheckProperties()
        {
            Assert.That(car.Make == "make" && car.Model == "model" && car.FuelConsumption == 1.0 && car.FuelCapacity == 5.0);
        }

        [Test]
        [TestCase("", "model", 1.0, 5.0)]
        [TestCase(null, "model", 1.0, 5.0)]
        [TestCase("make", "", 1.0, 5.0)]
        [TestCase("make", null, 1.0, 5.0)]

        public void CheckMakeAndModelValidations(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        [TestCase("make", "model", -1, 5.0)]
        [TestCase("make", "model", 1.0, -5)]

        public void CheckFuelConsumptionAndFuelCapcityValidations(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]

        public void CheckFuelAmountWhenReafueling()
        {
            int refuelQuantity = 0;
            Assert.Throws<ArgumentException>(() => car.Refuel(refuelQuantity));
        }

        [Test]
        public void CheckFuelAmountWhenItExceedCapacity()
        {
            int refuelQuantity = 10;
            car.Refuel(refuelQuantity);
            Assert.That(car.FuelAmount == car.FuelCapacity);
        }

        [Test]
        public void CheckFuelAmountWhenValuesAreOkay()
        {
            car = new Car("make", "model", 5.0, 50.0);
            int refuelQuantity = 6;
            car.Refuel(refuelQuantity);
            car.Refuel(refuelQuantity);
            Assert.That(car.FuelAmount == refuelQuantity * 2);
        }

        [Test]
        public void CheckDriveWhenFuelNeededIsMoreThanExpected()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(150));
        }

        [Test]
        public void CheckDriveWhenFuelNeededIsEnough()
        {
            double distance = 50;
            double fuel = 10;
            double fuelNeeded = (distance / 100) * car.FuelConsumption;

            car.Refuel(fuel);
            car.Drive(distance);

            Assert.That(car.FuelAmount == car.FuelCapacity - fuelNeeded);
        }
    }
}