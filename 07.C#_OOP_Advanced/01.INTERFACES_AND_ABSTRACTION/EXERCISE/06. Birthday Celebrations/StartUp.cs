using System;
using System.Collections.Generic;
using System.Globalization;
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

            switch (args[0])
            {
                case "Citizen":
                    IPerson citizen = new Citizen(args[1], int.Parse(args[2]), args[3], args[4]);
                    list.Add(citizen);
                    break;

                case "Pet":
                    IPerson pet = new Pet(args[1], args[2]);
                    list.Add(pet);
                    break;

                case "Robot":
                    IPerson robot = new Robot(args[1], args[2]);
                    list.Add(robot);
                    break;

                default:
                    break;
            }

            input = Console.ReadLine();
        }

        string year = Console.ReadLine();

        foreach (var item in list)
        {
            if (item is IBirthdate current && current.Birthdate.EndsWith(year))
            {
                Console.WriteLine(current.Birthdate);
            }
        }
    }
}
