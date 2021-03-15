using P03.DetailPrinter;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Junior : Employee
    {
        public Junior(string name, IReadOnlyCollection<string> documents)
            : base(name)
        {
            this.Documents = documents;
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
