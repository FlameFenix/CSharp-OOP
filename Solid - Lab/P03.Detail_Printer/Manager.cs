﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            return $"Employee Name: {this.Name}" + Environment.NewLine +
                   $"Employee title: {GetType().Name}" + Environment.NewLine +
                   $"Documents: " + Environment.NewLine +
                   $"{string.Join(Environment.NewLine, this.Documents)}";
        }
    }
}
