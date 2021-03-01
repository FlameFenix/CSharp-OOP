using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine()
                                      .Split(";", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

            List<Person> listPlayers = new List<Person>();
            List<Product> listProducts = new List<Product>();

            bool isEverythingValid = true;
            try
            {
                for (int i = 0; i < players.Length; i++)
                {
                    string[] playerInfo = players[i].Split("=", StringSplitOptions.RemoveEmptyEntries)
                                                .ToArray();
                    string playerName = playerInfo[0];
                    decimal playersMoney = decimal.Parse(playerInfo[1]);

                    Person currentPerson = new Person(playerName, playersMoney);

                    listPlayers.Add(currentPerson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            

            string[] products = Console.ReadLine()
                                  .Split(";", StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();
            try
            {
                for (int i = 0; i < products.Length; i++)
                {
                    string[] productInfo = products[i].Split("=", StringSplitOptions.RemoveEmptyEntries)
                                                                          .ToArray();
                    string productName = productInfo[0];
                    decimal productPrice = decimal.Parse(productInfo[1]);

                    Product currentProduct = new Product(productName, productPrice);

                    listProducts.Add(currentProduct);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            


            if (isEverythingValid)
            {
                string command = string.Empty;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();

                    string personName = cmdArgs[0];
                    string productName = cmdArgs[1];

                    Person currentPerson = listPlayers.Find(x => x.Name == personName);

                    Product currentProduct = listProducts.Find(x => x.Name == productName);

                    if (currentPerson.Money >= currentProduct.Cost && listPlayers.Contains(currentPerson) && listProducts.Contains(currentProduct))
                    {
                        currentPerson.AddProduct(currentProduct);
                        currentPerson.DecreaseMoney(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }

                }
            }

            if (isEverythingValid)
            {
                foreach (var item in listPlayers)
                {
                    if (item.Count == 0)
                    {
                        Console.WriteLine($"{item.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        }
    }
}
