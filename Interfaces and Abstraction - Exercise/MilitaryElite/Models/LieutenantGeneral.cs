using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : ILieutenantGeneral
    {
        

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.privates = new List<IPrivate>();
        }

        public List<IPrivate> privates { get; private set; }

        public decimal Salary { get; private set; }

        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}
