using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> list = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string name = input[0];
            int age = int.Parse(input[1]);

            Person current = new Person()
            {
                Name = name,
                Age = age
            };

            list.Add(current);
        }

        List<Person> result = list.Where(x => x.Age > 30).ToList().OrderBy(x => x.Name).ToList();

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
    }
}
