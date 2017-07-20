using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        ICollection<IPerson> list = new List<IPerson>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length == 3)
            {
                string name = args[0];
                int age = int.Parse(args[1]);
                string id = args[2];
                IPerson citizen = new Citizen(name, age, id);
                list.Add(citizen);
            }
            else
            {
                string model = args[0];
                string id = args[1];
                IPerson robot = new Robot(model, id);
                list.Add(robot);
            }

            input = Console.ReadLine();
        }

        string lastDigits = Console.ReadLine();

        foreach (var item in list)
        {
            if (item.Id.EndsWith(lastDigits))
            {
                Console.WriteLine(item.Id);
            }        
        }
    }
}
