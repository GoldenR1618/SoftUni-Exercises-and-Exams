using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        string command = Console.ReadLine();

        while (command != "Cops Are Here")
        {
            string[] args = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ExecuteCommand(args);
            command = Console.ReadLine();
        }
    }

    public void ExecuteCommand(string[] args)
    {
        switch (args[0])
        {
            case "register":
                int id = int.Parse(args[1]);
                string type = args[2];
                string brand = args[3];
                string model = args[4];
                int yearOfProduction = int.Parse(args[5]);
                int horsepower = int.Parse(args[6]);
                int acceleration = int.Parse(args[7]);
                int suspension = int.Parse(args[8]);
                int durability = int.Parse(args[9]);
                manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;

            case "check":

                break;

            case "open":

                break;

            case "participate":

                break;

            case "start":

                break;

            case "park":

                break;
            case "unpark":

                break;

            case "tune":

                break;

            default:
                break;
        }
    }
}
