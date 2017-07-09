using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Person> listOfPersons = new List<Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            try
            {
                string[] cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));
                listOfPersons.Add(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Team team = new Team("BestTeam");
        listOfPersons.ForEach(p => team.AddPlayer(p));

        Console.WriteLine(team.ToString());
    }
}