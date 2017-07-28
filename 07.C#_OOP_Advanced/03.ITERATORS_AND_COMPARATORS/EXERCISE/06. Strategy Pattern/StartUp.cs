using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        SortedSet<Person> nameSet = new SortedSet<Person>(new NameComparer());
        SortedSet<Person> ageSet = new SortedSet<Person>(new AgeComparer());

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Person currentPerson = new Person(args[0], int.Parse(args[1]));

            nameSet.Add(currentPerson);
            ageSet.Add(currentPerson);
        }

        if (nameSet.Count > 0)
        {
            Console.WriteLine(string.Join(Environment.NewLine, nameSet));
            Console.WriteLine(string.Join(Environment.NewLine, ageSet));
        }
    }
}