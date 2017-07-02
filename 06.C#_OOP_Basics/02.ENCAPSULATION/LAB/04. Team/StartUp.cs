using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        List<Person> persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Team team = new Team("BestTeam");
        persons.ForEach(p => team.AddPlayer(p));

        Console.WriteLine(team.ToString());
    }
}
