using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Manager("pesho", new List<string>() { "blqblq" , "asdsa", "asdasddf"});

            Employee junior = new Junior("Stancho", new List<string>() {"Tech-Co", "News", "bqblqlq"});

            List<Employee> employess = new List<Employee>() { employee, junior };

            DetailsPrinter printer = new DetailsPrinter(employess);

            printer.PrintDetails();
        }
    }
}
