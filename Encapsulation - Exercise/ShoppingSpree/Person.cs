using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            products = new List<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }

            }
        }

        public int Count 
        {
            get => this.products.Count;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DecreaseMoney(Product product)
        {
            this.money -= product.Cost;
        }

        public override string ToString()
        {
            return $"{this.name} - {string.Join(", ", products)}";
        }
    }
}
