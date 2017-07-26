using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(new Tupple<string, string>((input[0] + " " + input[1]), input[2]));

        input = Console.ReadLine().Split(' ');
        Console.WriteLine(new Tupple<string, int>(input[0], int.Parse(input[1])));

        input = Console.ReadLine().Split(' ');
        Console.WriteLine(new Tupple<int, double>(int.Parse(input[0]), double.Parse(input[1])));
    }
}
