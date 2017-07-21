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

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length == 4)   //Citizen
            {
                IPerson citizen = new Citizen(args[0], int.Parse(args[1]), args[2], args[3]);
                list.Add(citizen);
            }
            else    //Rebel
            {
                IPerson rebel = new Rebel(args[0], int.Parse(args[1]), args[2]);
                list.Add(rebel);
            }
        }

        string input = Console.ReadLine();

        while (input != "End")
        {
            if (list.Any(x => x.Name == input))
            {
                IBuyer person = (IBuyer)(list.First(x => x.Name == input));
                person.BuyFood();
            }

            input = Console.ReadLine();
        }

        int totalFood = 0;

        foreach (var item in list)
        {
            var current = (IBuyer)item;
            totalFood += current.Food;
        }

        Console.WriteLine(totalFood);
    }
}
