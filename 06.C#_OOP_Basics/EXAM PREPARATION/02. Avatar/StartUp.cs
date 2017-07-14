using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        //  250 / 300

        NationsBuilder nb = new NationsBuilder();

        string input = Console.ReadLine();

        while (input != "Quit")
        {
            List<string> args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = args[0];

            switch (command)
            {
                case "Bender":
                    nb.AssignBender(args);
                    break;

                case "Monument":
                    nb.AssignMonument(args);
                     break;

                case "Status":
                    Console.WriteLine(nb.GetStatus(args[1]));
                    break;

                case "War":
                    nb.IssueWar(args[1]);
                    break;

                default:
                    break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(nb.GetWarsRecord());
    }
}
