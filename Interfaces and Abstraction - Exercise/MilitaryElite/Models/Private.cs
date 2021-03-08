using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Private : IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}
