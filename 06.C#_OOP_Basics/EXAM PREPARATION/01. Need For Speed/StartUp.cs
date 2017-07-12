using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Startup
{
    private static void Main()
    {
        CarManager manager = new CarManager();

        string input = Console.ReadLine();

        while (input != "Cops Are Here")
        {
            string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (args[0])
            {
                case "register":
                    manager.Register(int.Parse(args[1]), args[2], args[3], args[4], int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7]), int.Parse(args[8]), int.Parse(args[9]));
                    break;

                case "check":
                    Console.WriteLine(manager.Check(int.Parse(args[1])));
                    break;

                case "open":
                    if (args[2] == "TimeLimit" || args[2] == "Circuit")
                    {
                        manager.Open(int.Parse(args[1]), args[2], int.Parse(args[3]), args[4], int.Parse(args[5]), int.Parse(args[6]));
                    }
                    else
                    {
                        manager.Open(int.Parse(args[1]), args[2], int.Parse(args[3]), args[4], int.Parse(args[5]));
                    }
                    break;

                case "participate":
                    manager.Participate(int.Parse(args[1]), int.Parse(args[2]));
                    break;

                case "start":
                    Console.WriteLine(manager.Start(int.Parse(args[1])));
                    break;

                case "park":
                    manager.Park(int.Parse(args[1]));
                    break;

                case "unpark":
                    manager.Unpark(int.Parse(args[1]));
                    break;

                case "tune":
                    manager.Tune(int.Parse(args[1]), args[2]);
                    break;

                default:
                    break;
            }

            input = Console.ReadLine();
        }
    }
}