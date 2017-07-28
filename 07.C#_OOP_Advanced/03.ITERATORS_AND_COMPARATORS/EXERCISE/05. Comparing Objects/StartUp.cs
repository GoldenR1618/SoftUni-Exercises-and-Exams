using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        List<Person> listOfPerson = new List<Person>();

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Person current = new Person(args[0], int.Parse(args[1]), args[2]);
            listOfPerson.Add(current);

            input = Console.ReadLine();
        }

        Person comparedPerson = listOfPerson[int.Parse(Console.ReadLine()) - 1];

        int equalPeoples = 0;
        int notEqualPeoples = 0;

        foreach (var person in listOfPerson)
        {
            if (comparedPerson.CompareTo(person) == 0)
            {
                equalPeoples++;
            }
            else
            {
                notEqualPeoples++;
            }
        }

        if (equalPeoples > 1)
        {
            Console.WriteLine($"{equalPeoples} {notEqualPeoples} {listOfPerson.Count}"); 
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}