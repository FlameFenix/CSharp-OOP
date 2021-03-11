using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            int index = 0;
            int countOfAnimals = 0;

            while (true)
            {
                
                if(index % 2 == 0)
                {
                    string[] cmdArgs = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string type = cmdArgs[0];
                    if(type == "End")
                    {
                        break;
                    }
                    string name = cmdArgs[1];
                    double weight = double.Parse(cmdArgs[2]);

                    if (type == nameof(Animals.Birds.Hen))
                    {
                        double wingSize = double.Parse(cmdArgs[3]);

                        Animal animal = new Animals.Birds.Hen(name, weight, wingSize);
                        animals.Add(animal);
                        animal.Sound();
                    }
                    else if (type == nameof(Animals.Birds.Owl))
                    {
                        double wingSize = double.Parse(cmdArgs[3]);
                        Animal animal = new Animals.Birds.Owl(name, weight, wingSize);
                        animals.Add(animal);
                        animal.Sound();
                    }
                    else if (type == nameof(Animals.Mammals.Cat))
                    {
                        string region = cmdArgs[3];
                        string breed = cmdArgs[4];
                        Animal animal = new Animals.Mammals.Cat(name, weight, region, breed);
                        animals.Add(animal);
                        animal.Sound();
                    }
                    else if (type == nameof(Animals.Mammals.Dog))
                    {
                        string region = cmdArgs[3];
                        Animal animal = new Animals.Mammals.Dog(name, weight, region);
                        animals.Add(animal);
                        animal.Sound();
                    }
                    else if (type == nameof(Animals.Mammals.Mouse))
                    {
                        string region = cmdArgs[3];
                        Animal animal = new Animals.Mammals.Mouse(name, weight, region);
                        animals.Add(animal);
                        animal.Sound();
                    }
                    else if (type == nameof(Animals.Mammals.Tiger))
                    {
                        string region = cmdArgs[3];
                        string breed = cmdArgs[4];
                        Animal animal = new Animals.Mammals.Tiger(name, weight, region, breed);
                        animals.Add(animal);
                        animal.Sound();
                    }

                    countOfAnimals++;

                    index++;
                }
                else
                {
                    string[] cmdArgs = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string foodType = cmdArgs[0];
                    int foodQuantity = int.Parse(cmdArgs[1]);
                    if(foodType == nameof(Foods.Fruit))
                    {
                        Food food = new Foods.Fruit(foodQuantity);
                        animals[countOfAnimals - 1].Eat(food);
                    }
                    else if(foodType == nameof(Foods.Meat))
                    {
                        Food food = new Foods.Meat(foodQuantity);
                        animals[countOfAnimals - 1].Eat(food);
                    }
                    else if (foodType == nameof(Foods.Seeds))
                    {
                        Food food = new Foods.Seeds(foodQuantity);
                        animals[countOfAnimals - 1].Eat(food);
                    }
                    else if (foodType == nameof(Foods.Vegetable))
                    {
                        Food food = new Foods.Vegetable(foodQuantity);
                        animals[countOfAnimals - 1].Eat(food);
                    }

                    index++;
                }
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
