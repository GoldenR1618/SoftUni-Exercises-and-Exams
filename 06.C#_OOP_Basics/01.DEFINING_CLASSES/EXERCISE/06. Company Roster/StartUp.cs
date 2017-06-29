using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        Team team = new Team();

        int n = int.Parse(Console.ReadLine());

        string input;

        while (n > 0)
        {
            input = Console.ReadLine();
            string[] args = input.Split(' ');

            string name = args[0];
            double salary = double.Parse(args[1]);
            string position = args[2];
            string department = args[3];
            string email = "n/a";
            int age = -1;

            if (args.Length == 6)
            {
                email = args[4];
                age = int.Parse(args[5]);
            }
            else if (args.Length == 5)
            {
                int parsedAge = 0;
                bool isParsed = int.TryParse(args[4], out parsedAge);

                if (isParsed)
                {
                    email = "n/a";
                    age = parsedAge;
                }
                else
                {
                    email = args[4];
                    age = -1;
                }
            }

            Employee current = new Employee
            {
                Name = name,
                Salary = salary,
                Position = position,
                Department = department,
                Email = email,
                Age = age
            };

            team.AddEmployee(current);

            n--;
        }

        var result = team.DepartmentWithTheHighestAverageSalary();

        Console.WriteLine($"Highest Average Salary: {result.Key}");

        foreach (var item in result.OrderByDescending(x => x.Salary))
        {
            Console.WriteLine($"{item.Name} {item.Salary:F2} {item.Email} {item.Age}");
        }
    }
}