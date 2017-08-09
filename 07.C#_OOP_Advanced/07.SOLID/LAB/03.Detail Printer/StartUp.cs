using System;
using System.Collections.Generic;

namespace _03.Detail_Printer
{
    public class StartUp
    {
        public static void Main()
        {
            Employee employee = new Employee("Employee");
            Manager manager = new Manager("Manager", new string[] { "Doc 1", "Doc 2", "Doc 3" });
            DetailsPrinter detailsPrinter = new DetailsPrinter(new List<Employee>(new Employee[] { employee, manager }));
            detailsPrinter.PrintDetails();
        }
    }
}
